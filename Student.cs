using MySql.Data.MySqlClient;
using MySqlX.XDevAPI;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Xml.Linq;

namespace ProjectBDB_2025CS196
{
    internal class Student
    {
        public string firstname {  get; set; }
        public string lastname { get; set; }
        public string regno { get; set; }
        public string phone { get; set; }
        public string email { get; set; }

        public int status {  get; set; }

        public Student(string firstname, string lastname, string regno, string phone, string email,int status)
        {
            this.firstname = firstname;
            this.lastname = lastname;
            this.regno = regno;
            this.phone = phone;
            this.email = email;
            this.status = status;
        }

        public void addStudent()
        {
            string query = $"INSERT INTO Student (FirstName, LastName, Contact, Email, RegistrationNumber, Status) "+ "VALUES (@fname, @lname, @phone, @email, @regno, @status)";
            var parameters = new Dictionary<string, object>
    {
        { "@fname", firstname },
        { "@lname", lastname },
        { "@phone", phone },
        { "@email", email },
        { "@regno", regno },
        { "@status", status }
     };
            try
            {
                DatabaseHelper.Instance.ExecuteParameterized(query, parameters);
                MessageBox.Show("Student Added Successfully! ","Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }

        public void EditStudent()
        {
            string query = $"UPDATE Student SET FirstName = '{firstname}', LastName = '{lastname}, WHERE RegistrationNumber = '{regno}'";
            DatabaseHelper.Instance.Update(query);
            MessageBox.Show("Student Edited !", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void DeleteStudent()
        {
            string query = $"DELETE FROM Student WHERE RegistrationNumber ='{regno}'";
            DatabaseHelper.Instance.Update(query);
           MessageBox.Show("Student Deleted !","Success",MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void SearchStudent()
        {
            string query = $"SELECT * FROM Student WHERE RegistrationNumber = '{regno}'";
            var reader = DatabaseHelper.Instance.GetData(query);
            if (reader.Read())
            {
                Console.WriteLine($"{reader["RegNo"]} - {reader["Name"]} - {reader["Department"]}-{reader["Session"]} - {reader["Cgpa"]}-{reader["Address"]}");
            }
            else
            {
              MessageBox.Show("Student not found !","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

       
    }
    }

