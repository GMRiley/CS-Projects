using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Data.SqlClient;
using System.Data;
using ToolLib;

namespace FinalProject
{
    class Student : Validator
    {
        private String firstName;
        private String lastName;
        private Double gradePA;
        private Int32 credits;
        private DateTime dateOB;
        private DateTime startDate;
        private String student_ID;
        private String degree;

        public String ErrorLog = "";
        public String FirstName
        {
            get { return firstName; }
            set
            {
                string temp;
                bool result = isName(value);
                if (result == true)
                    firstName = value;
                else
                {
                    temp = value;
                    ErrorLog += "ERROR: " + temp + " Must not contain special characters and numbers.\n";
                }
            }
        }

        public String LastName
        {
            get { return lastName; }
            set
            {
                string temp;
                bool result = isName(value);
                if (result == true)
                    lastName = value;
                else
                {
                    temp = value;
                    ErrorLog += "ERROR: " + temp + " Must not contain special characters and numbers.\n";
                }
            }
        }
        public Double GradePA
        {
            get { return gradePA; }
            set
            {
                string temp;
                bool result = isGPA(value.ToString());
                if (result == true)
                    gradePA = value;
                else
                {
                    temp = value.ToString();
                    ErrorLog += "ERROR: " + temp + " is not of a valid GPA format.";
                }
            }
        }
        public Int32 Credits
        {
            get { return credits; }
            set
            {
                string temp = value.ToString();
                int tester;
                if (int.TryParse(temp, out tester))
                    credits = value;
                else
                {
                    ErrorLog += "ERROR: " + temp + " Must be of valid integer format.";
                }
            }
        }
        public DateTime DateOB
        {
            get { return dateOB; }
            set { dateOB = value; }
        }
        public DateTime StartDate
        {
            get { return startDate; }
            set { startDate = value; }
        }
        public String Student_ID
        {
            get { return student_ID; }
            set { student_ID = value; }
        }
        public String Degree
        {
            get { return degree; }
            set { degree = value; }
        }
        public string AddARecord()
        {
            //Init string var
            string strResult = "";

            //Make a connection object
            SqlConnection conn = new SqlConnection();

            //Initialize it's properties
            conn.ConnectionString = @"Server=;Database=;User Id=;Password=;";     //Set the Who/What/Where of DB
            //*****************************************************************************************************
            //Record Adding
            string strSQL = "INSERT INTO StudentTable (Student_ID, FirstName, LastName, DateOB, StartDate, GradePA, Credits, Degree) VALUES (@Student_ID, @FirstName, @LastName, @DateOB, @StartDate, @GradePA, @Credits, @Degree)";
            SqlCommand comm = new SqlCommand();
            comm.CommandText = strSQL;
            comm.Connection = conn;

            //Parameter filling
            comm.Parameters.AddWithValue("@Student_ID", Student_ID);
            comm.Parameters.AddWithValue("@FirstName", FirstName);
            comm.Parameters.AddWithValue("@LastName", LastName);
            comm.Parameters.AddWithValue("@DateOB", DateOB);
            comm.Parameters.AddWithValue("@StartDate", StartDate);
            comm.Parameters.AddWithValue("GradePA", gradePA);
            comm.Parameters.AddWithValue("@Credits", Credits);
            comm.Parameters.AddWithValue("@Degree", Degree);
            

            //attempt to connect to the server
            try
            {
                conn.Open();                                        //Open connection to DB - Think of dialing a friend on phone
                int intRecs = comm.ExecuteNonQuery();
                strResult = "SUCCESS: Connected to Database, Inserted record!";       //Report that we made the connection
                conn.Close();                                       //Hanging up after phone call
            }
            catch (Exception err)                                   //If we got here, there was a problem connecting to DB
            {
                strResult = "ERROR: " + err.Message;                //Set feedback to state there was an error & error info
            }
            finally
            {

            }



            //Return resulting feedback string
            return strResult;
        }
        public DataSet SearchPerson()
        {
            DataSet data = new DataSet();
            SqlCommand comm = new SqlCommand();
            //Select statament to perform Search
            String strSQL = "SELECT Student_ID, FirstName, LastName, DateOB, StartDate, GradePA, Credits, Degree From StudentTable WHERE 0=0";


            if (FirstName.Length > 0)
            {
                strSQL += " AND FirstName Like @FirstName";
                comm.Parameters.AddWithValue("@FirstName", "%" + FirstName + "%");
            }
            if (LastName.Length > 0)
            {
                strSQL += " AND LastName Like @LastName";
                comm.Parameters.AddWithValue("@LastName", "%" + LastName + "%");
            }

            //Create DB tools and Configure
            SqlConnection conn = new SqlConnection();
            //Create the who, what, where of the DB
            string strConn = @GetConnected();
            conn.ConnectionString = strConn;

            //Fill in basic info to command object
            comm.Connection = conn;
            comm.CommandText = strSQL;

            //Create Data Adapter
            SqlDataAdapter dataAdapt = new SqlDataAdapter();
            dataAdapt.SelectCommand = comm;

            conn.Open();
            dataAdapt.Fill(data, "Person_Temp");
            conn.Close();

            return data;
        }
        public SqlDataReader FindOnePerson(int intPerson_ID)
        {
            SqlConnection conn = new SqlConnection();
            SqlCommand comm = new SqlCommand();

            string strConn = GetConnected();

            string sqlString = "Select * From StudentTable Where Student_ID = @Student_ID;";

            conn.ConnectionString = strConn;

            comm.Connection = conn;
            comm.CommandText = sqlString;
            comm.Parameters.AddWithValue("@Student_ID", intPerson_ID);

            conn.Open();

            return comm.ExecuteReader();
        }
        public string updateARecord()
        {
            Int32 intRecords = 0;
            string strResult = "";

            string strSQL = "Update StudentTable Set FirstName = @FirstName, LastName = @LastName, DateOB = @DateOB, StartDate = @StartDate, GradePA = @GradePA, Credits = @Credits, Degree = @Degree Where Student_ID = @Student_ID";

            SqlCommand comm = new SqlCommand();
            SqlConnection conn = new SqlConnection();

            string strConn = GetConnected();
            conn.ConnectionString = strConn;

            comm.CommandText = strSQL;
            comm.Connection = conn;

            comm.Parameters.AddWithValue("@FirstName", FirstName);
            comm.Parameters.AddWithValue("@LastName", LastName);
            comm.Parameters.AddWithValue("@DateOB", DateOB);
            comm.Parameters.AddWithValue("@StartDate", StartDate);
            comm.Parameters.AddWithValue("GradePA", gradePA);
            comm.Parameters.AddWithValue("@Credits", Credits);
            comm.Parameters.AddWithValue("@Degree", Degree);
            comm.Parameters.AddWithValue("@Student_ID", Student_ID);

            try
            {
                conn.Open();

                intRecords = comm.ExecuteNonQuery();
                strResult = intRecords.ToString() + "Records Updated.";
            }
            catch (Exception err)
            {
                strResult = "ERROR: " + err.Message;
            }
            finally
            {
                conn.Close();
            }
            return strResult;
        }
        public string DeleteOnePerson(String User_ID)
        {
            Int32 intRecords = 0;
            string strResult = "";

            SqlConnection conn = new SqlConnection();
            SqlCommand comm = new SqlCommand();

            string strConn = GetConnected();

            string sqlString = "Delete From StudentTable Where Student_ID = @Student_ID";

            conn.ConnectionString = strConn;

            comm.Connection = conn;
            comm.CommandText = sqlString;
            comm.Parameters.AddWithValue("@Student_ID", User_ID);

            try
            {
                conn.Open();
                intRecords = comm.ExecuteNonQuery();
                strResult = intRecords.ToString() + " Records Deleted.";
            }
            catch (Exception err)
            {
                strResult = "ERROR: " + err.Message;
            }
            finally
            {
                conn.Close();
            }
            return strResult;
        }
        private string GetConnected()
        {
            return "Server = ; Database = ; User Id = ; Password = ;";
        }
    }
    public class DegreeList
    {
        
        public IList<Degree> Architecture = new List<Degree>()
        {
            new Degree() { Category = "Architectural Building Technology", Class_ID = 0 },
            new Degree() { Category = "Interior Design", Class_ID = 1 },
            new Degree() { Category = "Civil Engineering Technology", Class_ID = 2 }
        };
        public IList<Degree> Automotive = new List<Degree>()
        {
            new Degree() { Category = "Automotive Technology", Class_ID = 3 },
            new Degree() { Category = "Auto Body", Class_ID = 4 },
            new Degree() { Category = "Automotive Collision Repair Technology", Class_ID = 5 },
            new Degree() { Category = "Automotive Technology with High Performance", Class_ID = 6 },
            new Degree() { Category = "Marine Technology", Class_ID = 7 }
        };
        public IList<Degree> Building = new List<Degree>()
        {
            new Degree() { Category = "Building Construction & Cabinetmaking Technology", Class_ID = 8 },
            new Degree() { Category = "Electrical Technology with Renewable Energy", Class_ID = 9 },
            new Degree() { Category = "Electrical Technology", Class_ID = 10 },
            new Degree() { Category = "Heating Technology", Class_ID = 11 },
            new Degree() { Category = "Plumbing Technology", Class_ID = 12 },
            new Degree() { Category = "Refrigeration-Air Conditioning Technology", Class_ID = 13 }
        };
        public IList<Degree> Communications = new List<Degree>()
        {
            new Degree() { Category = "Digital Media Production", Class_ID = 14 },
            new Degree() { Category = "Game Development & Simulation Programming", Class_ID = 15 },
            new Degree() { Category = "Graphics, Multimedia and Web Design", Class_ID = 16 }
        };
        public IList<Degree> Engineering = new List<Degree>()
        {
            new Degree() { Category = "Electro-Mechanical Engineering Technology", Class_ID = 16 },
            new Degree() { Category = "Architectural Building Engineering Technology", Class_ID = 17 },
            new Degree() { Category = "Electronics, Robotics & Drones Technology", Class_ID = 18 },
            new Degree() { Category = "Mechanical Engineering Technology", Class_ID = 19 },
            new Degree() { Category = "Welding Engineering Technology", Class_ID = 20 }
        };
        public IList<Degree> InfoTech = new List<Degree>()
        {
            new Degree() { Category = "Business Management", Class_ID = 21 },
            new Degree() { Category = "Game Development & Simulation Programming", Class_ID = 22 },
            new Degree() { Category = "Graphics, Multimedia and Web Design", Class_ID = 23 },
            new Degree() { Category = "Information Technology", Class_ID = 24 },
            new Degree() { Category = "Network Engineering Technology", Class_ID = 25 },
            new Degree() { Category = "Software Engineering Technology", Class_ID = 26 },
            new Degree() { Category = "Video Game Design", Class_ID = 27 }
        };
        public IList<Degree> Law = new List<Degree>()
        {
            new Degree() { Category = "Criminal Justice", Class_ID = 28 }
        };
        public IList<Degree> Health = new List<Degree>()
        {
            new Degree() { Category = "Nursing", Class_ID = 29 },
            new Degree() { Category = "Paramedic Technology", Class_ID = 30 },
            new Degree() { Category = "Occupational Therapy Assistant", Class_ID = 31 },
            new Degree() { Category = "Medical Assisting and Administration", Class_ID = 32 },
            new Degree() { Category = "Physicial Therapy Assistant", Class_ID = 33 },
            new Degree() { Category = "Surgical Technology", Class_ID = 34 },
            new Degree() { Category = "Medical Laboratory Technology", Class_ID = 35 },
            new Degree() { Category = "Respiratory Care", Class_ID = 36 }
        };
        public IList<Degree> Veterinary = new List<Degree>()
        {
            new Degree() { Category = "Veterinary Technology", Class_ID = 37 }
        };
        public class Degree
        {
            public String Category;
            public Int32 Class_ID;
        }
    }
}
