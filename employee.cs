using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Overriding
{
    class employee
    {
        private int employeeid;
        private string employeename;
        private double monthlysalary;
        private static int count = 1000;
        public employee(string employeename, double monthlysalary)
        {
            this.employeeid = ++employee.count;
            this.employeename = employeename;
            this.monthlysalary = monthlysalary;
        }
        public int pemployeeid { get { return this.employeeid; } }
        public string pemployeename { get { return this.employeename; } }
        public double pmonthlysalary { get { return this.monthlysalary; } }

        public string getdetails()
        {
            return this.employeeid + " " + this.employeename;
        }
        public string getwork()
        {
            return "dotnet developer";
        }
        public virtual double getsalary(int days)
        {
            int bonus = 2000;
            int tds = 800;
            double total = (this.monthlysalary / 30)*days + bonus - tds;
            return total;
        }
    }
}