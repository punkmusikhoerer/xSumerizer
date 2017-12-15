using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;


namespace xSumerizer_e
{
    class SumTab
    {
       public  string kommentar;
        public ObservableCollection<decimal> liste;
        public DateTime datum;
        
            //---------------------------------
            public SumTab()

        { liste = new ObservableCollection<decimal>();
            datum = DateTime.Now;
            kommentar = "kein Kommentar";

                
        }//ctor
        //-------------------------------------------
            public void AddValue(decimal d)
            {

            datum = DateTime.Now;
            liste.Add(d);

            }// add Value
        //------------------------------------------------

    public decimal Calc()
        {
            decimal retval;
            retval = 0.0M;

            foreach (decimal d in liste)
            { retval += d; }
            return retval;
        }// Calc

    }//class
}//namespace
