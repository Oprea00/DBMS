using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DBMS_lab_1
{
    public partial class Form1 : Form
    {
        private SqlConnection sqlConnection;
        private DataSet dataSet;
        private SqlDataAdapter daParent, daChild;
        private DataRelation dataRelation;
        private BindingSource bsParent, bsChild;

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            this.daChild.Update(this.dataSet, "Routine");
        }

        private void buttonLoadData_Click(object sender, EventArgs e)
        {
            this.sqlConnection = new SqlConnection(@"Data Source=DESKTOP-HBLSF31\SQLEXPRESS01;Initial Catalog=PersonalTrainingProgram;Integrated Security=True");
            this.dataSet = new DataSet();

            this.daParent = new SqlDataAdapter("SELECT * FROM Exercise", sqlConnection);
            SqlCommandBuilder cb = new SqlCommandBuilder(daParent);
            this.daParent.Fill(dataSet, "Exercise");

            this.daChild = new SqlDataAdapter("SELECT * FROM Routine", sqlConnection);
            cb = new SqlCommandBuilder(daChild);
            this.daChild.Fill(dataSet, "Routine");

            DataRelation dr = new DataRelation("FK_Exercise_Routine",
                dataSet.Tables["Exercise"].Columns["ExerciseID"], dataSet.Tables["Routine"].Columns["ExerciseID"]);
            this.dataSet.Relations.Add(dr);

            bsParent = new BindingSource();
            bsChild = new BindingSource();

            bsParent.DataSource = dataSet;
            bsParent.DataMember = "Exercise";

            bsChild.DataSource = bsParent;
            bsChild.DataMember = "FK_Exercise_Routine";

            this.dataGridParent.DataSource = bsParent;
            this.dataGridChild.DataSource = bsChild;
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void addButton_Click(object sender, EventArgs e)
        {
            try
            {
                sqlConnection.Open();
                SqlCommand command = new SqlCommand("INSERT INTO Routine(RoutineID,Name, Description,ExerciseID) VALUES (@RoutineID,@Name,@Description,@ExerciseID)", sqlConnection);

                command.Parameters.Add("RoutineID", SqlDbType.Int);
                command.Parameters["RoutineID"].Value = Convert.ToInt32(RoutineID_textBox.Text);

                command.Parameters.Add("Name", SqlDbType.VarChar);
                command.Parameters["Name"].Value = Name_textBox.Text;
                Console.WriteLine(Name_textBox.Text);

                command.Parameters.Add("Description", SqlDbType.VarChar);
                command.Parameters["Description"].Value = Description_textBox.Text;
                Console.WriteLine(Description_textBox.Text);

                command.Parameters.Add("ExerciseID", SqlDbType.Int);
                command.Parameters["ExerciseID"].Value = ExerciseID_textBox.Text;

                Console.WriteLine(command.Parameters.Count);
                daChild.InsertCommand = command;
                daChild.InsertCommand.ExecuteNonQuery();

                daChild = new SqlDataAdapter("SELECT * FROM Routine", sqlConnection);
                dataSet.Tables["Routine"].Clear();
                daChild.Fill(dataSet, "Routine");
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
            finally { sqlConnection.Close(); }
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            try
            {
                sqlConnection.Open();
                SqlCommand command = new SqlCommand("DELETE FROM Routine WHERE RoutineID=@RoutineID", sqlConnection);

                command.Parameters.Add("RoutineID", SqlDbType.Int);
                command.Parameters["RoutineID"].Value = Convert.ToInt32(RoutineID_textBox.Text);

                daChild.DeleteCommand = command;
                daChild.DeleteCommand.ExecuteNonQuery();

                daChild = new SqlDataAdapter("SELECT * FROM Routine", sqlConnection);
                dataSet.Tables["Routine"].Clear();
                daChild.Fill(dataSet, "Routine");
            } 
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
            finally { sqlConnection.Close(); }
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            try
            {
                sqlConnection.Open();
                SqlCommand command = new SqlCommand("UPDATE Routine SET Name=@Name, Description=@Description, ExerciseID=@ExerciseID WHERE RoutineID=@RoutineID", sqlConnection);

                command.Parameters.Add("Name", SqlDbType.VarChar);
                command.Parameters["Name"].Value = Name_textBox.Text;
                Console.WriteLine(Name_textBox.Text);

                command.Parameters.Add("Description", SqlDbType.VarChar);
                command.Parameters["Description"].Value = Description_textBox.Text;
                Console.WriteLine(Description_textBox.Text);

                command.Parameters.Add("ExerciseID", SqlDbType.Int);
                command.Parameters["ExerciseID"].Value = ExerciseID_textBox.Text;

                command.Parameters.Add("RoutineID", SqlDbType.Int);
                command.Parameters["RoutineID"].Value = Convert.ToInt32(RoutineID_textBox.Text);

                daChild.InsertCommand = command;
                daChild.InsertCommand.ExecuteNonQuery();

                daChild = new SqlDataAdapter("SELECT * FROM Routine", sqlConnection);
                dataSet.Tables["Routine"].Clear();
                daChild.Fill(dataSet, "Routine");
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
            finally { sqlConnection.Close(); }
        }
    }
}
