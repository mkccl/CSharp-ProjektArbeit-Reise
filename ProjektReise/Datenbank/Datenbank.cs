using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using Microsoft.VisualBasic;

namespace ProjektReise.Datenbank
{
    public class Datenbank
    {
        /**
         * Verbindungsstring
         */
        private string db = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\C#\ProjektReise\ProjektFluggesellschaft.mdf;Integrated Security=True;Connect Timeout=30";

        private string fluggastId;
        private string ticketId;
        private string fluggastTicket;
        private string fluggastTicketArt;
        private string fluggastName;
        private string gebaeckPreis;
        private string gebeackId;
        private string gebeackMind, gepeackMax;
        private string gepeackPreis;
        private string idVonGebeack;
        private string abflughafen, ankunftflughafen;
        private string flugNummer;
        private string flugzeugId;
        private string fleugzeugName;
        private string flugzeugSitzplatz;
        private string flugzeugSitzplatzFrei;

        public bool flugzeugInformationen(string fliegerId)
        {
            try
            {
                SqlConnection connection = new SqlConnection(db);
                string sql = "SELECT * FROM Flugzeug WHERE FlugzeugId = " + fliegerId; 
                SqlCommand cmd = new SqlCommand(sql, connection);
                connection.Open();
                SqlDataReader sdr = cmd.ExecuteReader();

                while (sdr.Read())
                {
                    FlugzeugName = sdr["FlugzeugName"].ToString();
                    FlugzeugSitzplatz = sdr["FlugzeugSitzplatz"].ToString();
                    FlugzeugSitzplatzFrei = sdr["FlugzeugSitzplatzFrei"].ToString();
                    
                }
                
                connection.Close();
                return true;
            }
            catch (ArgumentNullException ane)
            {
                Console.WriteLine(ane);
            }
            catch (InvalidCastException ice)
            {
                Console.WriteLine(ice);
            }
            catch (SqlException sqle)
            {
                Console.WriteLine("Datensatz nicht vorhanden");
            }
            catch (IOException ioe)
            {
                Console.WriteLine(ioe);
            }
            catch (InvalidOperationException ioe)
            {
                Console.WriteLine(ioe);
            }

            return false;
        }
        public bool TicketIdauslesen(string fluggastTicket)
        {
            try
            {
                SqlConnection connection = new SqlConnection(db);
                string sql = string.Format("SELECT * FROM Ticket WHERE FluggastTicket = '{0}'", fluggastTicket);
                SqlCommand cmd = new SqlCommand(sql,connection);
                connection.Open();
                SqlDataReader sdr = cmd.ExecuteReader();

                while (sdr.Read())
                {
                    TicketId = sdr["TicketId"].ToString();
                    FluggastId = sdr["FluggastId"].ToString();
                    FluggastTicket = sdr["FluggastTicket"].ToString();
                    FluggastTicketArt = sdr["FluggastTicketTyp"].ToString();
                    IdVonGebeack = sdr["GebaeckId"].ToString();
                    Abflughafen = sdr["Abflughafen"].ToString();
                    Ankunftflughafen = sdr["Zielflughafen"].ToString();
                    FlugNummer = sdr["Flugnummer"].ToString();
                    FlugzeugId = sdr["FlugzeugId"].ToString();

                }
                
                SqlConnection connection2 = new SqlConnection(db);
                string sql2 = string.Format("SELECT * FROM Gebaeck WHERE GebaeckId = {0}", IdVonGebeack);
                SqlCommand cmd2 = new SqlCommand(sql2,connection2);
                connection2.Open();
                SqlDataReader sdr2 = cmd2.ExecuteReader();

                while (sdr2.Read())
                {
                    GebaeckPreis = sdr2["GebaeckPreis"].ToString();
                    GebeackId = sdr2["GebaeckId"].ToString();
                    GebeackMind = sdr2["GebaeckMindWert"].ToString();
                    GepeackMax = sdr2["GebaeckMaxWert"].ToString();
                    
                }
                
                SqlConnection connection3 = new SqlConnection(db);
                string sql3 = string.Format("SELECT * FROM Fluggast WHERE FluggastId = {0}", FluggastId);
                SqlCommand cmd3 = new SqlCommand(sql3,connection3);
                connection3.Open();
                SqlDataReader sdr3 = cmd3.ExecuteReader();

                while (sdr3.Read())
                {
                    FluggastName = sdr3["Name"].ToString();
                }
                
                connection.Close();
                connection2.Close();
                connection3.Close();
                return true;
            }
            catch (ArgumentNullException ane)
            {
                Console.WriteLine(ane);
            }
            catch (InvalidCastException ice)
            {
                Console.WriteLine(ice);
            }
            catch (SqlException sqle)
            {
                Console.WriteLine("Datensatz nicht vorhanden");
            }
            catch (IOException ioe)
            {
                Console.WriteLine(ioe);
            }
            catch (InvalidOperationException ioe)
            {
                Console.WriteLine(ioe);
            }
            
            return false;
        }
        public bool FluggastInformationen(string fluggastId)
        {
            try
            {
                SqlConnection connection = new SqlConnection(db);
                string sql = "SELECT * FROM Fluggast WHERE FluggastId = " + fluggastId; 
                SqlCommand cmd = new SqlCommand(sql, connection);
                connection.Open();
                SqlDataReader sdr = cmd.ExecuteReader();

                while (sdr.Read())
                {
                    FluggastId = sdr["FluggastId"].ToString();
                    FluggastName = sdr["Name"].ToString();
                }
                connection.Close();
                return true;
            }
            catch (ArgumentNullException ane)
            {
                Console.WriteLine(ane);
            }
            catch (InvalidCastException ice)
            {
                Console.WriteLine(ice);
            }
            catch (SqlException sqle)
            {
                Console.WriteLine("Datensatz nicht vorhanden");
            }
            catch (IOException ioe)
            {
                Console.WriteLine(ioe);
            }
            catch (InvalidOperationException ioe)
            {
                Console.WriteLine(ioe);
            }

            return false;
        }
        public List<PilAusgabe> AuslesenPil(string flugnummer)
        {
            try
            {
                SqlConnection connection = new SqlConnection(db);
                string sql = string.Format("SELECT * FROM Ticket WHERE Flugnummer = '{0}'", flugnummer);
                SqlCommand cmd = new SqlCommand(sql,connection);
                connection.Open();
                SqlDataReader sdr = cmd.ExecuteReader();

                List<PilAusgabe> temp = new List<PilAusgabe>();
            
                while (sdr.Read())
                {
                    temp.Add(new PilAusgabe() {
                        TicketId = sdr["TicketId"].ToString(), 
                        FluggastId = sdr["FluggastId"].ToString(),
                        FlugGastTicket = sdr["FluggastTicket"].ToString(),
                        FluGastTicketTyp = sdr["FluggastTicketTyp"].ToString(),
                        GebaeckId = sdr["GebaeckId"].ToString(),
                        AbflugHafen = sdr["Abflughafen"].ToString(),
                        ZielflugHafen = sdr["Zielflughafen"].ToString(),
                        GebaeckIdent = sdr["GebaeckIdentifkationsnummer"].ToString(),
                        Flugnummer = sdr["Flugnummer"].ToString(),
                        FlugzeugId = sdr["FlugzeugId"].ToString(),
                        Sitzplatze = sdr["Sitzplatz"].ToString()
                    });
                }

                return temp;
            }
            catch (ArgumentNullException ane)
            {
                Console.WriteLine(ane);
            }
            catch (InvalidCastException ice)
            {
                Console.WriteLine(ice);
            }
            catch (SqlException sqle)
            {
                Console.WriteLine("Datensatz nicht vorhanden");
            }
            catch (IOException ioe)
            {
                Console.WriteLine(ioe);
            }
            catch (InvalidOperationException ioe)
            {
                Console.WriteLine(ioe);
            }

            return null;
        }
        public bool BorderCardErstellen(string namePass, string sitzplatz, string flugnummer, string gate, string borderzeit)
        {
            try
            {
                SqlConnection connection = new SqlConnection(db);
                string sql = string.Format("INSERT INTO BorderCard (NamePass, Sitzplatz, Flugnummer, Gate, BorderZeit) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}')", namePass, sitzplatz, flugnummer, gate, borderzeit );
                SqlCommand cmd = new SqlCommand(sql, connection);
                connection.Open();
                cmd.ExecuteNonQuery();
                connection.Close();
                return true;
            }
            catch (ArgumentNullException ane)
            {
                Console.WriteLine(ane);
            }
            catch (InvalidCastException ice)
            {
                Console.WriteLine(ice);
            }
            catch (SqlException sqle)
            {
                Console.WriteLine(sqle);
            }
            catch (IOException ioe)
            {
                Console.WriteLine(ioe);
            }
            catch (InvalidOperationException ioe)
            {
                Console.WriteLine(ioe);
            }
            
            return false;
        }
        public bool SitzplatzZuweisen(string fluggastTicket, string sitzPlatz)
        {
            try
            {
                SqlConnection connection = new SqlConnection(db);
                string sql = string.Format("UPDATE Ticket " +
                                           "SET Sitzplatz = '{0}' " +
                                           "WHERE FluggastTicket = '{1}'" ,sitzPlatz , fluggastTicket );
                SqlCommand cmd = new SqlCommand(sql, connection);
                connection.Open();
                cmd.ExecuteNonQuery();
                connection.Close();
            }
            catch (ArgumentNullException ane)
            {
                Console.WriteLine(ane);
            }
            catch (InvalidCastException ice)
            {
                Console.WriteLine(ice);
            }
            catch (SqlException sqle)
            {
                Console.WriteLine("Datensatz nicht vorhanden");
            }
            catch (IOException ioe)
            {
                Console.WriteLine(ioe);
            }
            catch (InvalidOperationException ioe)
            {
                Console.WriteLine(ioe);
            }
            
            return false;
        }
        public bool GebaeckEinchecken(string fluggastTicket, string indNummer)
        {
            try
            {
                SqlConnection connection = new SqlConnection(db);
                string sql = string.Format("UPDATE Ticket " +
                                           "SET GebaeckIdentifkationsnummer = '{0}' " +
                                           "WHERE FluggastTicket = '{1}'" ,indNummer , fluggastTicket );
                SqlCommand cmd = new SqlCommand(sql, connection);
                connection.Open();
                cmd.ExecuteNonQuery();
                connection.Close();
            }
            catch (ArgumentNullException ane)
            {
                Console.WriteLine(ane);
            }
            catch (InvalidCastException ice)
            {
                Console.WriteLine(ice);
            }
            catch (SqlException sqle)
            {
                Console.WriteLine("Datensatz nicht vorhanden");
            }
            catch (IOException ioe)
            {
                Console.WriteLine(ioe);
            }
            catch (InvalidOperationException ioe)
            {
                Console.WriteLine(ioe);
            }
            
            return false;
        }

        public string FlugzeugSitzplatzFrei
        {
            get => flugzeugSitzplatzFrei;
            set => flugzeugSitzplatzFrei = value;
        }

        public string FlugzeugSitzplatz
        {
            get => flugzeugSitzplatz;
            set => flugzeugSitzplatz = value;
        }

        public string FlugzeugName
        {
            get => fleugzeugName;
            set => fleugzeugName = value;
        }

        public string FlugzeugId
        {
            get => flugzeugId;
            set => flugzeugId = value;
        }

        public string FlugNummer
        {
            get => flugNummer;
            set => flugNummer = value;
        }

        public string Ankunftflughafen
        {
            get => ankunftflughafen;
            set => ankunftflughafen = value;
        }

        public string Abflughafen
        {
            get => abflughafen;
            set => abflughafen = value;
        }

        public string IdVonGebeack
        {
            get => idVonGebeack;
            set => idVonGebeack = value;
        }

        public string GepeackMax
        {
            get => gepeackMax;
            set => gepeackMax = value;
        }

        public string GebeackMind
        {
            get => gebeackMind;
            set => gebeackMind = value;
        }

        public string GebeackId
        {
            get => gebeackId;
            set => gebeackId = value;
        }

        public string GebaeckPreis
        {
            get => gebaeckPreis;
            set => gebaeckPreis = value;
        }
        
        public string FluggastName
        {
            get => fluggastName;
            set => fluggastName = value;
        }

        public string FluggastTicketArt
        {
            get => fluggastTicketArt;
            set => fluggastTicketArt = value;
        }

        public string FluggastTicket
        {
            get => fluggastTicket;
            set => fluggastTicket = value;
        }

        public string TicketId
        {
            get => ticketId;
            set => ticketId = value;
        }

        public string FluggastId
        {
            get => fluggastId;
            set => fluggastId = value;
        }
    }
}