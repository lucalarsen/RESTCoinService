using RestCoinService.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestCoinService.Model
{
    public class Coin
    {
        private int _id;
        //public static int nextid = 1;
        public int ID
        {
            get { return _id; }
            set { _id = value; }
        }

        private string _genstand;

        public string Genstand
        {
            get { return _genstand; }
            set { _genstand = value; }
        }

        private int _bud;

        public int Bud
        {
            get { return _bud; }
            set { _bud = value; }
        }

        private string _navn;

        public string Navn
        {
            get { return _navn; }
            set { _navn = value; }
        }

        public Coin(string genstand, int bud, string navn)
        {
            Genstand = genstand;
            Bud = bud;
            Navn = navn;
            ID = CoinController.nextid++;
        }

        public Coin()
        {
            ID = CoinController.nextid++;
        }


    }
}
