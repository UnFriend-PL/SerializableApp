using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace SerializableAppv2
{
    public partial class Form1 : Form
    {
        List<Person> persons = new List<Person>();
        string serializePersonsPath = "persons.xml";
        public Form1()
        {
            InitializeComponent();
            DesetializeObjectsFromXML();
            //MessageBox.Show("Poprawnie wczytano liste osob!");
        }

        private void DesetializeObjectsFromXML(bool customFile = false)
        {
            if(customFile)
            {
                OpenFileDialog dialog = new OpenFileDialog();
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    MessageBox.Show("Wybrales: " + dialog.FileName);
                    serializePersonsPath = dialog.FileName;
                }
            }
            if (!File.Exists(serializePersonsPath))
            {
                return;
            }
            var deserialize = new XmlSerializer(typeof(List<Person>));
            using (var reader = new StreamReader(serializePersonsPath))
            {
                persons = (List<Person>)deserialize.Deserialize(reader);
            }
            UpdatePersonsComboBox();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (customSavePath.Checked)
            {
                SaveFileDialog dialog = new SaveFileDialog();
                dialog.Filter = "XML-File | *.xml";
                dialog.FileName= serializePersonsPath;
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    serializePersonsPath = dialog.FileName;
                }
            }
            else
            {
                serializePersonsPath = "persons.xml";
            }
            var serialize = new XmlSerializer(typeof(List<Person>));
            using (var writer = new StreamWriter(serializePersonsPath))
            {
                serialize.Serialize(writer, persons);
            }
            MessageBox.Show("Zapisano liste osob.");
        }

        private void UpdatePersonsComboBox()
        {
            ChoosePerson.DataSource = null;
            ChoosePerson.DisplayMember = "Name";
            ChoosePerson.DataSource = persons;
        }

        private void AddPersonButton_Click(object sender, EventArgs e)
        {
            if (NameValue.Text != string.Empty && SurnameValue.Text != string.Empty && AgeValue.Text != string.Empty)
            {
                int id = persons.Any() ? persons.IndexOf(persons.Last()) + 1 : 0;
                Person person = new Person(id, NameValue.Text, SurnameValue.Text, Convert.ToInt32(AgeValue.Text));
                persons.Add(person);
                UpdatePersonsComboBox();
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            persons.Remove((Person)ChoosePerson.SelectedItem);
            UpdatePersonsComboBox();
            MessageBox.Show("Usunieto!");
        }

        private void ModifyButton_Click(object sender, EventArgs e)
        {
            var person = (Person)ChoosePerson.SelectedItem;
            if (person != null)
            {
                person.Name = NameValue.Text;
                person.Surname = SurnameValue.Text;
                person.Age = Convert.ToInt32(AgeValue.Text);
            }
            UpdatePersonsComboBox();
        }

        private void ChoosePerson_TextChanged(object sender, EventArgs e)
        {
            var person = (Person)ChoosePerson.SelectedItem;
            if (person != null)
            {
                NameValue.Text = person.Name;
                SurnameValue.Text = person.Surname;
                AgeValue.Text = person.Age.ToString();
            }
        }

        private void loadButton_Click(object sender, EventArgs e)
        {
            DesetializeObjectsFromXML(true);
        }
    }
}
