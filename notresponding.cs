using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
namespace Nothing
{
    #region Notresponding
    public class Notresponding
    {
        #region Member Variables
        protected int _nim;
        protected int _nik;
        protected string _nama;
        protected string _alamat;
        #endregion
        #region Constructors
        public Notresponding() { }
        public Notresponding(int nik, string nama, string alamat)
        {
            this._nik=nik;
            this._nama=nama;
            this._alamat=alamat;
        }
        #endregion
        #region Public Properties
        public virtual int Nim
        {
            get {return _nim;}
            set {_nim=value;}
        }
        public virtual int Nik
        {
            get {return _nik;}
            set {_nik=value;}
        }
        public virtual string Nama
        {
            get {return _nama;}
            set {_nama=value;}
        }
        public virtual string Alamat
        {
            get {return _alamat;}
            set {_alamat=value;}
        }
        #endregion
    }
    #endregion
}