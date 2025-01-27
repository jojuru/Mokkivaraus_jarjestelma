﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Mokkivaraus
{
    public class Laskutus
    {
        public string lasku_id { get; set; }
        public string varaus_id { get; set; }
        public string summa { get; set; }
        public string alv { get; set; }
        public string maksettu { get; set; }
        public string laskun_tyyppi { get; set; }
        public string etunimi { get; set; }
        public string sukunimi { get; set; }
        public string puhelinnro { get; set; }
        public string email { get; set; }
        public string mokkinimi { get; set; }
        public string varattu_alkupvm { get; set; }
        public string varattu_loppupvm { get; set; }
        public string varattu_pvm { get; set; }
        public bool isOverdue { get; set; }

        public string MaksettuTeksti => maksettu == "1" ? "Maksettu" : "Maksamatta";

        public Laskutus() { }

        public Laskutus(string lasku_id, string varaus_id, string summa, 
            string alv, string alue, string maksettu, 
            string laskun_tyyppi, string etunimi, string sukunimi, 
            string email, string puhelinnro, string varattu_pvm,
            string mokkinimi, string varattu_alkupvm, string varattu_loppupvm)
        {
            this.lasku_id = lasku_id;
            this.varaus_id = varaus_id;
            this.summa = summa;
            this.alv = alv;
            this.maksettu = maksettu;
            this.laskun_tyyppi = laskun_tyyppi;
            this.etunimi = etunimi;
            this.sukunimi = sukunimi;
            this.email = email;
            this.puhelinnro = puhelinnro;
            this.varattu_pvm = varattu_pvm;
            this.mokkinimi = mokkinimi;
            this.varattu_alkupvm = varattu_alkupvm;
            this.varattu_loppupvm = varattu_loppupvm;
        }
        
    }
}
