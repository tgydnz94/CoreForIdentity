using CoreForIdentity.Model.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoreForIdentity.Model.Abstract
{
    public abstract class BaseModel
    {
        // Bütün sınıflarımızda bulunması gereken ortak özelliklerimizi bu sınıfa tanımlıyoruz.
        public int ID { get; set; }

        private DateTime _createdDate = DateTime.Now;
        public DateTime CreatedDate
        {
            get { return _createdDate; }
            set { _createdDate = value; }
        }
        public DateTime? UpdatedDate { get; set; } //? boş geçilebilir(nullable)
        public DateTime? DeletedDate { get; set; }

        private Statu _statu = Statu.Active;
        public Statu Sata 
        {
            get { return _statu; }
            set { _statu= value; }
        }
    }
}
