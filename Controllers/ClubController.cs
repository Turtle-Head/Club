using Club.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.Elfie.Diagnostics;
using Microsoft.Data.SqlClient;
namespace Club.Controllers
{

    public class ClubController : Controller
    {
        List<ClubMembers> list = new List<ClubMembers>();
        const string connString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Stark\OneDrive\Documents\ClubSongs.mdf;Integrated Security=True;Connect Timeout=30";
        public IActionResult Index()
        {
            return View(GetInfoFromDB());
        }
        public static List<ClubMembers> GetInfoFromDB()
        {
            List<ClubMembers> list = new List<ClubMembers>();



            const string connString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Stark\OneDrive\Documents\ClubSongs.mdf;Integrated Security=True;Connect Timeout=30";

            using (SqlConnection conn = new SqlConnection(connString))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM ClubMembers"))
                {
                    cmd.Connection = conn;
                    conn.Open();
                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        ClubMembers clubMembers = new ClubMembers
                        {
                            MemberID = Convert.ToInt32(sdr["MemberID"]),
                            FirstName = sdr["FirstName"].ToString(),
                            LastName = sdr["LastName"].ToString(),
                            Level = sdr["Level"].ToString(),
                            DOB = sdr["DOB"].ToString()
                        };
                        list.Add(clubMembers);
                    }
                    sdr.Close();
                    conn.Close();
                }

            }


            return list;
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(ClubMembers clubMembers)
        {
            const string connString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Stark\OneDrive\Documents\ClubSongs.mdf;Integrated Security=True;Connect Timeout=30";

            string sql = $"INSERT INTO ClubMembers (MemberID, FirstName, LastName, Level, DOB) Values ('{clubMembers.MemberID}','{clubMembers.FirstName}','{clubMembers.LastName}','{clubMembers.Level}','{clubMembers.DOB}')";
            try 
            {
                using SqlConnection conn = new SqlConnection(connString);
                {
                    conn.Open();
                    using SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                // show an error message
                ViewBag.ErrorMessage = "An error occured: " + ex.Message;
                return View();
            }
            return View("Index", GetInfoFromDB());

        }
        [HttpGet]


        public ActionResult Edit(int id)
        {
            const string connString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Stark\OneDrive\Documents\ClubSongs.mdf;Integrated Security=True;Connect Timeout=30";
            ClubMembers clubMembers = new ClubMembers();
            try
            {
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    using (SqlCommand cmd = new SqlCommand($"SELECT * FROM ClubMembers WHERE MemberID = '{id}'"))
                    {
                        cmd.Connection = conn;
                        conn.Open();
                        SqlDataReader sdr = cmd.ExecuteReader();
                        while (sdr.Read())
                        {
                            clubMembers.MemberID = Convert.ToInt32(sdr["MemberID"]);
                            clubMembers.FirstName = sdr["FirstName"].ToString();
                            clubMembers.LastName = sdr["LastName"].ToString();
                            clubMembers.Level = sdr["Level"].ToString();
                            clubMembers.DOB = sdr["DOB"].ToString();


                        }
                        sdr.Close();
                        conn.Close();
                    }

                }
                
            }
            catch (Exception ex)
            {
                ViewBag.ErrorMessage = "An error occured: " + ex.Message;
                Console.WriteLine($"{ex.Data}");
                return View();
            }
            return View("Index", GetInfoFromDB());
        }
        [HttpPost]
        public ActionResult Edit(int MemberID, ClubMembers clubMembers)
        {
            string sql = $"UPDATE ClubMembers Set " +
                $"FirstName = @FirstName, " +
                $"LastName = @LastName, " +
                $"Level = @Level, " +
                $"DOB = @DOB " +
                $"WHERE MemberID = '{clubMembers.MemberID}'; ";

            const string conn = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Stark\OneDrive\Documents\ClubSongs.mdf;Integrated Security=True;Connect Timeout=30";
            try
            {
                using (SqlConnection connobj = new SqlConnection(conn))
                {
                    connobj.Open();
                    using (SqlCommand cmd = new SqlCommand(sql, connobj))
                    {
                        cmd.Parameters.AddWithValue("@MemberID", clubMembers.MemberID);
                        cmd.Parameters.AddWithValue("@FirstName", clubMembers.FirstName);
                        cmd.Parameters.AddWithValue("@LastName", clubMembers.LastName);
                        cmd.Parameters.AddWithValue("@Level", clubMembers.Level);
                        cmd.Parameters.AddWithValue("@DOB", clubMembers.DOB);
                        cmd.ExecuteNonQuery();
                    }

                }
            }
            catch(SqlException ex)
            {
                ViewBag.ErrorMessage = "An error occured: " + ex.Message;
                Console.WriteLine($"{ex.Data}");
                return View();
            }
            return View("Index", GetInfoFromDB());
        }
        [HttpGet]
        public ActionResult Delete(int id)
        {
            const string connString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Stark\OneDrive\Documents\ClubSongs.mdf;Integrated Security=True;Connect Timeout=30";
            ClubMembers clubMembers = new ClubMembers();
            try 
            {
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    using (SqlCommand cmd = new SqlCommand($"SELECT * FROM ClubMembers WHERE MemberID = '{id}'"))
                    {
                        cmd.Connection = conn;
                        conn.Open();
                        SqlDataReader sdr = cmd.ExecuteReader();
                        while (sdr.Read())
                        {
                            clubMembers.MemberID = Convert.ToInt32(sdr["MemberID"]);
                            clubMembers.FirstName = sdr["FirstName"].ToString();
                            clubMembers.LastName = sdr["LastName"].ToString();
                            clubMembers.Level = sdr["Level"].ToString();
                            clubMembers.DOB = sdr["DOB"].ToString();


                        }
                        sdr.Close();
                        conn.Close();
                    }
                }
            }
            catch(SqlException ex) 
            {
                ViewBag.ErrorMessage = "An error occured: " + ex.Message;
                Console.WriteLine($"{ex.Data}");
                return View();
            }
            return View("Index", GetInfoFromDB());
        }
        [HttpPost]
        public ActionResult Delete(int id, ClubMembers clubmembers)
        {
            const string connString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Stark\OneDrive\Documents\ClubSongs.mdf;Integrated Security=True;Connect Timeout=30";
            try
            {
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    using (SqlCommand cmd = new SqlCommand($"DELETE FROM ClubMembers WHERE MemberID = '{id}'"))
                    {
                        cmd.Connection = conn;
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        conn.Close();
                    }

                }
            }
            catch (SqlException ex)
            {
                ViewBag.ErrorMessage = "An error occured: " + ex.Message;
                Console.WriteLine($"{ex.Data}");
                return View();
            }
            return View("Index", GetInfoFromDB());
        }

        public ActionResult Details(int id)
        {
            const string connString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Stark\OneDrive\Documents\ClubSongs.mdf;Integrated Security=True;Connect Timeout=30";
            ClubMembers clubMembers = new ClubMembers();
            using (SqlConnection conn = new SqlConnection(connString))
            {
                using (SqlCommand cmd = new SqlCommand($"SELECT * FROM ClubMembers WHERE MemberID = '{id}'"))
                {
                    cmd.Connection = conn;
                    conn.Open();
                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        clubMembers.MemberID = Convert.ToInt32(sdr["MemberID"]);
                        clubMembers.FirstName = sdr["FirstName"].ToString();
                        clubMembers.LastName = sdr["LastName"].ToString();
                        clubMembers.Level = sdr["Level"].ToString();
                        clubMembers.DOB = sdr["DOB"].ToString();


                    }
                    sdr.Close();
                    conn.Close();
                }

            }
            return View(clubMembers);
        }
    }
}




