using System;
using System.Data;

class Program
{
    static void Main()
    {
        // Create two DataTable instances.
        DataTable Donors = new DataTable("Donors");
        Donors.Columns.Add("Donor_Name");
        Donors.Columns.Add("Donor_CNIC");
        Donors.Rows.Add("Suli", 1);
        Donors.Rows.Add("Shana", 2);

        DataTable BloodTypes1 = new DataTable("BloodTypes");
        BloodTypes1.Columns.Add("Blood_Group");
        BloodTypes1.Columns.Add("RH_Factor");
        BloodTypes1.Rows.Add(1, "B");
        BloodTypes1.Rows.Add(2, "Negative");

        // Create a DataSet and put both tables in it.
        DataSet set = new DataSet("Blood_Bank");
        set.Tables.Add(Donors);
        set.Tables.Add(BloodTypes1);

        // Visualize DataSet.
        Console.WriteLine(set.GetXml());
        Console.ReadLine();
    }
}
