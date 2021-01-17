using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace generator
{
    public partial class Form1 : Form
    {

        private string strConnection = "Data Source=localhost;Initial Catalog=hopital;User ID=sa;Password=sql";
        //private static string strConnection = "Data Source=10.4.169.201;Initial Catalog=DBGroupe2;User ID=MStJean;Password=sql";

        private List<string> listeMaladie = new List<string>() { "Coronariennes", "Muscle cardiaque"
                , "Angor (ou angine de poitrine)","Infarctus du myocarde", "Cardiomyopathie", "", "Insuffisance cardiaque"
                , "valves cardiaques", "Endocardite", "Valvulopathies cardiaques", "péricarde", "Tumeur du cerveau",
                "leucémies", "carcinome hépatocellulaire", "cancer du larynx", "cancer de l'endomètre"
                , "maxillaire aiguë", "sphénoïdale aiguë", "Laryngite aiguë", "Laryngite obstructive aiguë (croup)" };

        private List<string> allergie = new List<string>() { "Les arachides", "Le blé", "Les fruits de mer", "Les graines de sésame",
                "Le lait", "Les noix", "Les œufs", "Le soja", "Les sulfites", "La moutarde"};


        private List<string> name = new List<string>() { "Brenda/Cox", "Judith/Phillips", "Joan/Hernandez", "Dorothy/Campbell", "Shirley/Gray", "Julie/Foster",
                "Ruth/Simmons", "Raymond/Gonzales", "Betty/Young", "Adam/Harris", "Steve/Morris", "Samuel/Perez", "Ann/Bell", "Judy/Miller", "Beverly/Parker"
                , "Marie/Powell", "Arthur/Diaz", "Joseph/Thompson", "Rachel/Wright", "Patrick/Bryant", "Lisa/Moore", "Joshua/Richardson", "Roger/Brown", "Tina/Adams", "Sara/Barnes",
                "Irene/Sanders", "Carol/Howard", "Steven/Williams", "Shawn/Anderson", " Shawn/Anderson", "Juan/Perry", "Kevin/Lewis", "Michelle/Reed", "Gary/James",
                "Bobby/Davis", "Harold/Griffin", "Lori/Torres", "Katherine/Hall", "Laura/Scott", "Henry/Ward", "Ronald/Bennett", "Jonathan/Price", "Andrew/Allen","Billy/Garcia","Bonnie/Rivera","Larry/Lopez",
                "Lois/Martin","Theresa/Edwards","Norma/Baker","Mary/Wilson","Annie/Ross","John/Brooks","Tammy/Carter","Maria/Evans","Jose/Russell","Linda/Sanchez","Rose/Smith","Janice/Taylor","Jeremy/Nelson",
                "Ryan/Johnson","Diana/Cook","Jeffrey/Stewart","Alice/Jackson","Barbara/Jones","Aaron/Robinson","Kathryn/Peterson","Heather/Murphy","Russell/Roberts","Christine/Thomas",
                "Lillian/Rogers","Helen/Cooper","Timothy/Butler","Pamela/Clark","Kathy/Hill","Fred/Jenkins","Alan/Martinez","Jesse/Collins","Wanda/Gonzalez","Anna/Alexander","Gerald/King",
                "Jimmy/Walker","Nancy/Long","Paula/Bailey","Doris/Coleman","Willie/Henderson","Benjamin/Patterson","Janet/Green","Rebecca/Washington","Bruce/Wood","Deborah/Watson",
                "Stephanie/Rodriguez","Richard/Hughes","Sarah/Flores","Justin/Mitchell","Ernest/White","Teresa/Lee","Amy/Kelly","Susan/Morgan","Charles/Turner", "jp/jf"};


        private List<string> listeCategorie = new List<string>() { "Urine", "signe vitaux", "Microbiologie", "Hétamologie", "chimie du sang", "Térapie", "Diagnostique", "Teste diagnostique" };

        private List<string> abo = new List<string>() { "a+", "a-", "ab+", "ab-", "b+", "b-" };

        private List<string> dead = new List<string>() { "suicide", "accident auto", "cancer", "accident travail", "peste noire", "parachute" };

        private List<string> virus = new List<string>() { "virus d'Abelson ", "betaretrovirus", "Capillovirus", "Cardiovirus", "Carlavirus", "Carmovirus",
            "CMV", "virus du coryza", "Coxackie A virus", "Coxsackie B", "Crypotovirus", "Cucumovirus", "Cypovirus", "cytomégalovirus", "cytomegalovirus(groupe)",
            "cytomegalovirus congénita" };

        private List<string> dna = new List<string>() { "CACGGGTAGG", "ATCATCAGTA", "ATAAGGATAG", "TGGGAAAGCT", "CACAGACCAC", "CGCCTATAGG",
            "GGGTGCTTAC", "TTTTACAAAA", "AGCGACTGTT", "AGTATAACCC", "CACGAGGATT", "CGAAAAGGTG", "AACCGACCCG", "GTCGATCCGG", "AGGGACGGGC", "CTCAAAGCCG"
            , "CGTCACGACG", "GCTGTCGGCC", "CGTAACAGAA", "ACCCCGGAGT", "AAGCTCCCGT", "GGGCCTGGAT", "AGAACAGCCC", "TGGTGGGCCC" };


        private List<int> role_code = new List<int>() { 1, 2, 3, 4 };
        private List<string> role_name = new List<string>() { "Administrateur", "Super-User", "Medecin", "Utilisateur" };


        List<DataTest> data = new List<DataTest>() {
            new DataTest(1,"po"), new DataTest(1, "temp"), new DataTest(1, "wt"), new DataTest(1, "bp"),
            new DataTest(2, "Organisme"),
            new DataTest(3, "wbc"), new DataTest(3, "wbc"), new DataTest(3, "eoc"), new DataTest(3, "plts"),
            new DataTest(4, "gl"),new DataTest(4, "bun"),new DataTest(4, "cr"),
            new DataTest(5, "azathiop mg"),new DataTest(5, "pred mg"),new DataTest(5, "cya"),
            new DataTest(6, "diagnostique"),
            new DataTest(7, "x/rays mg"),new DataTest(7, "renal scan"),new DataTest(7, "ultra sond")};


        public Form1()
        {
            InitializeComponent();
        }

        private void Transplantation_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection(strConnection);
            cn.Open();

            for (int i = 1; i <= 100; i++)
            {
                String value = name[i - 1];
                Char delimiter = '/';
                String[] substrings = value.Split(delimiter);
                string nom = substrings[1];

                string medecin = "Dr " + nom;

                SqlCommand cmd = new SqlCommand("insert into [dbo].[Transplantation]([Code_Transplant],[Nom_Medecin] ,[Code_Patient],[Code_Donneur])" +
                   "values(@Code_Transplant, @Nom_Medecin, @Code_Patient, @Code_Donneur)", cn);
                cmd.Parameters.AddWithValue("@Code_Transplant", i);
                cmd.Parameters.AddWithValue("@Nom_Medecin", medecin);
                cmd.Parameters.AddWithValue("@Code_Patient", i);
                cmd.Parameters.AddWithValue("@Code_Donneur", i);
                cmd.ExecuteNonQuery();
            }
            cn.Close();

            MessageBox.Show("Patient sucess");
        }

        private void Donneur_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection(strConnection);
            cn.Open();

            List<DateTime> liste = new List<DateTime>();

            SqlCommand listeCM = new SqlCommand("select Date_Transplant_Patient FROM Patient", cn);

            SqlDataReader reader = listeCM.ExecuteReader();
            while (reader.Read())
            {
                liste.Add(reader.GetDateTime(0));
            }
            reader.Close();

            Random random = new Random();
            for (int i = 1; i <= 100; i++)
            {

                string a_b_o = abo[random.Next(abo.Count - 1)];
                int vivant = random.Next(0, 2);

                string allergies = allergie[random.Next(allergie.Count - 1)];

                string mort = dead[random.Next(dead.Count - 1)];

                string strvirus = virus[random.Next(virus.Count - 1)];

                string d_n_a = dna[random.Next(dna.Count - 1)];

                DateTime traitement = liste[i - 1];

                SqlCommand cmd = new SqlCommand("insert into [dbo].[Donneur] ([Code_Do], [Vivant_Do], [ADN_Do], [Allergie_Do], [Raison_Deces_Do], [Virus], [Groupe_Sanguin_Do], [Date_Transplant_Do], [Code_Patient])" +
                   "values(@Code_Do, @Vivant_Do, @ADN_Do, @Allergie_Do, @Raison_Deces_Do, @Virus, @Groupe_Sanguin_Do, @Date_Transplant_Do, @Code_Patient)", cn);
                cmd.Parameters.AddWithValue("@Code_Do", i);
                cmd.Parameters.AddWithValue("@Vivant_Do", vivant);
                cmd.Parameters.AddWithValue("@ADN_Do", d_n_a);
                cmd.Parameters.AddWithValue("@Allergie_Do", allergies);
                cmd.Parameters.AddWithValue("@Raison_Deces_Do", mort);
                cmd.Parameters.AddWithValue("@Virus", strvirus);
                cmd.Parameters.AddWithValue("@Groupe_Sanguin_Do", a_b_o);
                cmd.Parameters.AddWithValue("@Date_Transplant_Do", traitement);
                cmd.Parameters.AddWithValue("@Code_Patient", i);
                cmd.ExecuteNonQuery();
            }
            cn.Close();

            MessageBox.Show("Patient sucess");
        }


        private void Categorie_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection(strConnection);
            cn.Open();

            for (int i = 1; i <= listeCategorie.Count - 1; i++)
            {

                SqlCommand cmd = new SqlCommand("insert into [dbo].[Categorie]([Nom_Categorie])" +
                   "values(@Nom_Categorie)", cn);
                cmd.Parameters.AddWithValue("@Nom_Categorie", listeCategorie[i]);

                cmd.ExecuteNonQuery();
            }
            cn.Close();

            MessageBox.Show("Patient sucess");
        }

        private void Tests_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection(strConnection);
            cn.Open();

            List<int> liste = new List<int>();
            SqlCommand listeCM = new SqlCommand("select Code_Categorie FROM Categorie", cn);
            SqlDataReader reader = listeCM.ExecuteReader();
            while (reader.Read())
            {
                liste.Add(reader.GetInt32(0));
            }
            reader.Close();

            int cpt = 1;
            foreach (var data in data)
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO Tests (Code_Test, Nom_test, Code_Categorie)" +
                    "VALUES (@Code_Test, @Nom_test, @Code_Categorie)", cn);
                cmd.Parameters.AddWithValue("@Code_Test", cpt);
                cmd.Parameters.AddWithValue("@Nom_test", data.name);
                cmd.Parameters.AddWithValue("@Code_Categorie", data.code);

                cmd.ExecuteNonQuery();
                cpt++;
            }
            cn.Close();

            MessageBox.Show("Patient sucess");
        }

        private void TestsPatient_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection(strConnection);
            cn.Open();

            Random random = new Random();
            int cpt = 1;
            foreach (var data in data)
            {

                int mois = random.Next(1, 12);
                int jour = random.Next(1, 29);
                int anne = random.Next(2016, 2017);

                string dataF = anne + "-" + jour + "-" + mois;
                string dataA = anne + "-" + mois + "-" + jour;

                int testResultat = random.Next(1, 10);

                int codePatient = random.Next(1, 100);

                SqlCommand cmd = new SqlCommand("INSERT INTO [Tests Patient] ([Code_Patient_TP],[Code_Test_TP],[Resultat],[Date_test],[Code_Patient],[Code_Test])" +
               "VALUES (@Code_Patient_TP, @Code_Test_TP, @Resultat, @Date_test, @Code_Patient, @Code_Test)", cn);
                cmd.Parameters.AddWithValue("@Code_Patient_TP", codePatient);
                cmd.Parameters.AddWithValue("@Code_Test_TP", data.code);
                cmd.Parameters.AddWithValue("@Resultat", testResultat);
                cmd.Parameters.AddWithValue("@Date_test", dataA);
                cmd.Parameters.AddWithValue("@Code_Patient", codePatient);
                cmd.Parameters.AddWithValue("@Code_Test", data.code);

                cmd.ExecuteNonQuery();
                cpt++;
            }

            MessageBox.Show("Patient sucess");
        }

        private void Patient_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection(strConnection);
            cn.Open();

            Random random = new Random();

            for (int i = 1; i <= 100; i++)
            {
                int randomNumber = random.Next(1000000, 9999999);

                int mois = random.Next(1, 12);
                int jour = random.Next(1, 29);
                int anne = random.Next(1930, 2010);

                int moist = random.Next(1, 12);
                int jourt = random.Next(1, 29);
                int annet = random.Next(2010, 2016);

                int bit1 = random.Next(0, 2);
                int bit2 = random.Next(0, 2);
                int bit3 = random.Next(0, 2);
                int bit4 = random.Next(0, 2);
                int bit5 = random.Next(0, 2);
                int bit6 = random.Next(0, 2);

                int c = random.Next(0, 2);

                String value = name[i - 1];
                Char delimiter = '/';
                String[] substrings = value.Split(delimiter);
                string prenom = substrings[0];
                string nom = substrings[1];

                string allergies = allergie[random.Next(allergie.Count - 1)];

                string maladie = listeMaladie[random.Next(listeMaladie.Count - 1)];

                SqlCommand cmd = new SqlCommand("insert into [dbo].[Patient] ([Code_Patient],[Nom_Patient],[Prenom_Patient]" +
                ",[NAS_Patient],[DateNaissance_Patient],[Allergie_Patient],[Maladie_Original_Patient],[Date_Transplant_Patient]" +
                ",[Coter_Transplant_Patient],[ABV_Patient],[Anergy_Patient],[PPD_Patient],[HbsAg_Patient],[CMV_Patient]" +
                ",[Transfusion_Patient],[VV_ByPass_Patient],[Antifib_Lytics_Patient]) " +

                "values(@Code_Patient, @Nom_Patient, @Prenom_Patient, @NAS_Patient, @DateNaissance_Patient, " +
                "@Allergie_Patient, @Maladie_Original_Patient, @Date_Transplant_Patient, @Coter_Transplant_Patient, " +
                "@ABV_Patient, @Anergy_Patient, @PPD_Patient, @HbsAg_Patient, @CMV_Patient, @Transfusion_Patient, @VV_ByPass_Patient, " +
                "@Antifib_Lytics_Patient)", cn);


                string dateNaissanceF = anne + "-" + jour + "-" + mois;
                string dateNaissanceA = anne + "-" + mois + "-" + jour;


                string dateTransfusionF = annet + "-" + jourt + "-" + moist;
                string dateTransfusionA = annet + "-" + moist + "-" + jourt;

                cmd.Parameters.AddWithValue("@Code_Patient", i);
                cmd.Parameters.AddWithValue("@Nom_Patient", nom);
                cmd.Parameters.AddWithValue("@Prenom_Patient", prenom);
                cmd.Parameters.AddWithValue("@NAS_Patient", randomNumber);
                cmd.Parameters.AddWithValue("@DateNaissance_Patient", dateNaissanceA);
                cmd.Parameters.AddWithValue("@Allergie_Patient", allergies);
                cmd.Parameters.AddWithValue("@Maladie_Original_Patient", maladie);
                cmd.Parameters.AddWithValue("@Date_Transplant_Patient", dateTransfusionA);

                char cote;
                if (c == 0)
                {
                    cote = 'd';
                }
                else
                {
                    cote = 'g';
                }

                cmd.Parameters.AddWithValue("@Coter_Transplant_Patient", cote);
                cmd.Parameters.AddWithValue("@ABV_Patient", i);
                cmd.Parameters.AddWithValue("@Anergy_Patient", GenerateName(15));
                cmd.Parameters.AddWithValue("@PPD_Patient", bit1);
                cmd.Parameters.AddWithValue("@HbsAg_Patient", bit2);
                cmd.Parameters.AddWithValue("@CMV_Patient", bit3);
                cmd.Parameters.AddWithValue("@Transfusion_Patient", i);
                cmd.Parameters.AddWithValue("@VV_ByPass_Patient", bit4);
                cmd.Parameters.AddWithValue("@Antifib_Lytics_Patient", bit5);

                cmd.ExecuteNonQuery();
            }
            cn.Close();

            MessageBox.Show("Patient sucess");
        }

        private void Role_User_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection(strConnection);
            cn.Open();

            for (int i = 0; i <= role_code.Count - 1; i++)
            {
                SqlCommand cmd = new SqlCommand("insert into Role_User ([Code_Role], [Nom_Role])" +
                   "values(@Code_Role, @Nom_Role)", cn);
                cmd.Parameters.AddWithValue("@Code_Role", role_code[i]);
                cmd.Parameters.AddWithValue("@Nom_Role", role_name[i]);

                cmd.ExecuteNonQuery();
            }
            cn.Close();

            MessageBox.Show("Patient sucess");
        }

        private void Utilisateur_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection(strConnection);
            cn.Open();

            List<string> prenom = new List<string>();
            SqlCommand listePrenom = new SqlCommand("select Prenom_Patient FROM Patient", cn);
            SqlDataReader readerPrenom = listePrenom.ExecuteReader();
            while (readerPrenom.Read())
            {
                prenom.Add(readerPrenom.GetString(0));
            }
            readerPrenom.Close();

            List<string> nom = new List<string>();
            SqlCommand listeNom = new SqlCommand("select Prenom_Patient FROM Patient", cn);
            SqlDataReader readerNom = listeNom.ExecuteReader();
            while (readerNom.Read())
            {
                nom.Add(readerNom.GetString(0));
            }
            readerNom.Close();

            for(int i = 1; i <= 100;i ++)
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO Utilisateur ([Code_U],[Nom_U] ,[Mdp_Y],[Nom_Utilisateur_U],[Prenom_U],[Code_Role])" +
                    "VALUES(@Code_U, @Nom_U, @Mdp_Y, @Nom_Utilisateur_U, @Prenom_U, @Code_Role)", cn);

                cmd.Parameters.AddWithValue("@Code_U", i);
                cmd.Parameters.AddWithValue("@Nom_U", nom[i-1] + "_" + i);

                cmd.Parameters.AddWithValue("@Mdp_Y", "pw");
                cmd.Parameters.AddWithValue("@Nom_Utilisateur_U", nom[i-1]);

                cmd.Parameters.AddWithValue("@Prenom_U", prenom[i-1]);
                cmd.Parameters.AddWithValue("@Code_Role", 4);

                cmd.ExecuteNonQuery();
               
            }
            MessageBox.Show("Patient sucess");
        }


        private Random r = new Random();
        public string GenerateName(int len)
        {
            string[] consonants = { "b", "c", "d", "f", "g", "h", "j", "k", "l", "m", "l", "n", "p", "q", "r", "s", "sh", "zh", "t", "v", "w", "x" };
            string[] vowels = { "a", "e", "i", "o", "u", "ae", "y" };
            string Name = "";
            Name += consonants[r.Next(consonants.Length)].ToUpper();
            Name += vowels[r.Next(vowels.Length)];
            int b = 2;
            while (b < len)
            {
                Name += consonants[r.Next(consonants.Length)];
                b++;
                Name += vowels[r.Next(vowels.Length)];
                b++;
            }

            return Name;
        }
    }

}

public class DataTest
{
    public int code { get; set; }
    public string name { get; set; }

    public DataTest(int code, String name)
    {
        this.code = code;
        this.name = name;
    }
}