using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    public class Faehre
    {
        // die Variablen heißen in C# Felder
        private String name;
        private Decimal laenge;
        private int baujahr;

        public int Baujahr
        {
            get
            {
                return baujahr;
            }

            set
            {
                baujahr = value;
            }
        }

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public decimal Laenge
        {
            get
            {
                return laenge;
            }

            set
            {
                laenge = value;
            }
        }

        //Standardkonstruktor; wird automatisch angelegt; nicht sichtbar!!!
        public Faehre()
        {

        }
        public int MaxGewicht { get; set; }
    }
}

