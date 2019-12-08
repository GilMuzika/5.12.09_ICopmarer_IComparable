using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace _5._12._09_ICopmarer_person
{
    public partial class MainForm : Form
    {
        private Label lblAllThepersonsInfo = new Label();
        private ScrollablePanel pnlAllThePersonsProperties = new ScrollablePanel();
        private ToolTip toolTip1 = new ToolTip();
        private string[] namesToUsing = null; 
        private Random _rnd = new Random();
        private XmlSerializer _serializer = new XmlSerializer(typeof(Person[]));
        const string SAVE_DIR_NAME = "Serialized_Objects_Saved_Here";
        const string SAVED_FILE_PATH = SAVE_DIR_NAME + "\\arrayOfSavedPersons.xml";


        public MainForm()
        {
            InitializeComponent();
            initializeControls();
            ReadFromFile();
            ReadAndRestoreSerializedObjects();
        }
        private void initializeControls()
        {
            
            pnlAllThePersonsProperties.Location = new Point(cmbPersons.Location.X, cmbPersons.Location.Y + cmbPersons.Height + 10);
            pnlAllThePersonsProperties.Height = this.ClientRectangle.Height - pnlAllThePersonsProperties.Location.Y - 10;            
            pnlAllThePersonsProperties.Width = cmbPersons.Width;
            pnlAllThePersonsProperties.Visible = false;
            lblAllThepersonsInfo.AutoSize = true;
            lblAllThepersonsInfo.Location = new Point(5, 5);
            pnlAllThePersonsProperties.Controls.Add(lblAllThepersonsInfo);
            this.Controls.Add(pnlAllThePersonsProperties);

            toolTip1.AutoPopDelay = 5000;
            toolTip1.InitialDelay = 1;
            toolTip1.ReshowDelay = 500;
            toolTip1.ShowAlways = true;
            toolTip1.IsBalloon = true;
            toolTip1.SetToolTip(btnPrintAlThePersons, "First time the default comparer is sorting by Id");


            cmbPrintAllSortedBy.Items.Add(Person.AgeComparer);
            cmbPrintAllSortedBy.Items.Add(Person.HeightComparer);
            cmbPrintAllSortedBy.Items.Add(Person.IdComparer);
            cmbPrintAllSortedBy.Items.Add(Person.NameComparer);

            Application.ApplicationExit += (object sender, EventArgs e) => 
                {
                    Directory.CreateDirectory(SAVE_DIR_NAME);
                    Person[] toSerialization = new Person[cmbPersons.Items.Count];
                    for(int i = 0; i < toSerialization.Length; i++) toSerialization[i] = (cmbPersons.Items[i] as ComboItem).Item;
                   
                    using (Stream fileStream = new FileStream(SAVED_FILE_PATH, FileMode.Create))
                    {
                        _serializer.Serialize(fileStream, toSerialization);
                        MessageBox.Show($"All the persons are saved to the disk in the XML format and will be restored on the next run of the applocation. \n\nThe path to the file is:\n{Directory.GetCurrentDirectory()}\\{SAVED_FILE_PATH}");
                    }
                };
        }
        private void ReadAndRestoreSerializedObjects()
        {
            if (!Directory.Exists(SAVE_DIR_NAME)) { MessageBox.Show("The directory with the serialised data is missing, so no data can be restored"); return; }
            else
            {
                if (!File.Exists(SAVED_FILE_PATH)) { MessageBox.Show("The file with the serialised data is missing, so no data can be restored"); return; }
            }

            Person[] deserializedArray;
            using (Stream fileStream = new FileStream(SAVED_FILE_PATH, FileMode.Open))
            {
                deserializedArray = this._serializer.Deserialize(fileStream) as Person[];
            }

            foreach (var s in deserializedArray) cmbPersons.Items.Add(new ComboItem(s));

            cmbPersons.SelectedIndex = cmbPersons.Items.Count - 1;
        }

        private void ReadFromFile()
        {
            string names = string.Empty;
            try
            {
                names = File.ReadAllText("_names.txt");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message} \n\nSo the program will use the defult names");
                names = " Alfred Benny Connnor Daniel Eran ";
            }
            namesToUsing = names.Split(new char[] { ' ', '\t', '\n' }).Where(x => !String.IsNullOrEmpty(x)).ToArray();
        }


        private void btnCreateANewPerson_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();

            cmbPersons.Items.Add(new ComboItem(new Person((int)numAge.Value, (int)numHeight.Value, txtName.Text)));
            txtName.Text = randomName();

            numAge.Value = rnd.Next(120);
            numHeight.Value = rnd.Next(80, 200);

            cmbPersons.SelectedIndex = cmbPersons.Items.Count - 1;
        }

        private string randomName()
        {
            return namesToUsing[this._rnd.Next(0, namesToUsing.Length - 1)].Trim();
        }

        private void cmbPersons_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblPersonProperties.Visible = true;
            pnlAllThePersonsProperties.Visible = false;

            Person selectedPerson = (cmbPersons.SelectedItem as ComboItem).Item;
            lblPersonProperties.Text = selectedPerson.ToString();
        }


        private void PrintPersonArray(Person[] persons)
        {
            lblAllThepersonsInfo.Text = string.Empty;
            foreach (var s in persons) lblAllThepersonsInfo.Text += s.ToString();
        }

        private void btnPrintAlThePersons_Click(object sender, EventArgs e)
        {
            PrintAlThePersons(null);   
        }

        private void PrintAlThePersons(IComparer<Person> comparer)
        {
            cmbPrintAllSortedBy.SelectedItem = Person.NameComparer;

            if (cmbPersons.Items.Count == 0) MessageBox.Show("First create at least one person");

            lblPersonProperties.Visible = false;
            pnlAllThePersonsProperties.Visible = true;


            List<Person> persons = new List<Person>();
            foreach (var s in cmbPersons.Items) persons.Add((s as ComboItem).Item);
            Person[] personsArr = persons.ToArray();
            if (comparer == null) 
            {
                Array.Sort(personsArr); 
                Person.isDefaultComparerUsed = true;

                changeModifier();
                toolTip1.SetToolTip(btnPrintAlThePersons, $"From now on the default comparer is sorting by {Statics.defaultComparerModifier}");

            }
            else Array.Sort(personsArr, comparer);
            PrintPersonArray(personsArr);
        }

        private void changeModifier()
        {
            string str = (cmbPrintAllSortedBy.SelectedItem as IComparer<Person>).GetType().Name;
            int ind = str.IndexOf("By") + 2;

            Statics.defaultComparerModifier = str.Substring(ind).ToLower();            
        }

        private void btnPrintAllSortedBy_Click(object sender, EventArgs e)
        {
            PrintAlThePersons(cmbPrintAllSortedBy.SelectedItem as IComparer<Person>);
        }

        private void cmbPrintAllSortedBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            changeModifier();
            toolTip1.SetToolTip(btnPrintAlThePersons, $"From now on the default comparer is sorting by {cmbPrintAllSortedBy.SelectedItem}");
        }
    }
}
