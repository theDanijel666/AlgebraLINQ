using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace LINQ_to_sql
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string constr = ConfigurationManager.
                            ConnectionStrings["LINQ_to_sql.Properties.Settings.linq_to_sqlConnectionString"].
                            ConnectionString;

            LinqToSqlDataContext baza_podataka= new LinqToSqlDataContext(constr);

            Console.WriteLine("============================================");
            Console.WriteLine("Unos zaposleniuka sa LINQ to SQL: ");
            Console.WriteLine("============================================");

            UnosNovogZaposlenika(baza_podataka);

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("============================================");
            Console.WriteLine("Ažuriranje zaposlenika sa LINQ to SQL: ");
            Console.WriteLine("============================================");

            AzurirajZaposlenika(baza_podataka, 2);

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("============================================");
            Console.WriteLine("Brisanje zaposlenika sa LINQ to SQL: ");
            Console.WriteLine("============================================");

            BrisanjeZaposlenika(baza_podataka, 2);


            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("============================================");
            Console.WriteLine("Popis zaposlenika sa LINQ to SQL: ");
            Console.WriteLine("============================================");

            var listaZaposlenika = baza_podataka.Zaposleniks.ToList();
            Console.WriteLine("ID       Ime     Prezime     Email       Telefon     Adresa      Odjel");
            foreach(var z in listaZaposlenika)
            {
                z.Odjel = baza_podataka.Odjels.Where(o => o.ID == z.OdjelID).FirstOrDefault();
                Console.WriteLine($"{z.ID}       {z.Ime}     {z.Prezime}     {z.Email}       {z.Telefon}     {z.Adresa}      {z.Odjel.Naziv}");
            }

            var zaposlenici = baza_podataka.Dohvat_zaposlenika().ToList();

        }

        static void UnosNovogZaposlenika(LinqToSqlDataContext baza_podataka)
        {
            Zaposlenik novi_zaposlenik=new Zaposlenik();
            novi_zaposlenik.Ime = "Nikola";
            novi_zaposlenik.Prezime = "Tesla";
            novi_zaposlenik.Email = "nikola.tesla@algebra.hr";
            novi_zaposlenik.Telefon = "0987654321";
            novi_zaposlenik.Adresa = "Smiljani";
            novi_zaposlenik.OdjelID = 1;

            baza_podataka.Zaposleniks.InsertOnSubmit(novi_zaposlenik);

            baza_podataka.SubmitChanges();

            Zaposlenik z = baza_podataka.Zaposleniks.FirstOrDefault(zap => zap.Prezime.Contains("Tesla"));

            Console.WriteLine($"Zaposlenik br.{z.ID}, {z.Ime} {z.Prezime}, Stanuje u {z.Adresa}, kontakt {z.Telefon}");
        }

        static void AzurirajZaposlenika(LinqToSqlDataContext baza_podataka, int IDZaposlenik)
        {
            Zaposlenik zaposlenik_za_azuriranje = baza_podataka.Zaposleniks.FirstOrDefault(za => za.ID == IDZaposlenik);
            if (zaposlenik_za_azuriranje == null)
            {
                Console.WriteLine("Zaposlenik s brojem " + IDZaposlenik + " nije nađen!");
                return;
            }

            zaposlenik_za_azuriranje.Ime = "Nikola Genije";

            baza_podataka.SubmitChanges();

            //Zaposlenik z = baza_podataka.Zaposleniks.FirstOrDefault(zap => zap.Prezime.Contains("Tesla"));
            Zaposlenik z = (from zap in baza_podataka.Zaposleniks
                            where zap.Prezime.Contains("Tesla")
                            select zap).FirstOrDefault();

            Console.WriteLine($"Zaposlenik br.{z.ID}, {z.Ime} {z.Prezime}, Stanuje u {z.Adresa}, kontakt {z.Telefon}");
        }

        static void BrisanjeZaposlenika(LinqToSqlDataContext baza_podataka, int IDZaposlenik)
        {
            Zaposlenik zaposlenik_za_brisanje=baza_podataka.Zaposleniks.Where(zap=>zap.ID== IDZaposlenik).FirstOrDefault();

            if(zaposlenik_za_brisanje == null)
            {
                Console.WriteLine("Zaposlenik s brojem " + IDZaposlenik + " nije nađen i ne može biti obrisan!");
                return;
            }

            baza_podataka.Zaposleniks.DeleteOnSubmit(zaposlenik_za_brisanje);

            baza_podataka.SubmitChanges();

            Console.WriteLine("Zaposlenik uspješno obrisan!");
        }
    }
}
