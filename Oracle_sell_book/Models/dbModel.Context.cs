﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Oracle_sell_book.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class Entities : DbContext
    {
        public Entities()
            : base("name=Entities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<CHUDE> CHUDEs { get; set; }
        public virtual DbSet<CTHD> CTHDs { get; set; }
        public virtual DbSet<HOADON> HOADONs { get; set; }
        public virtual DbSet<KHACHHANG> KHACHHANGs { get; set; }
        public virtual DbSet<NXB> NXBs { get; set; }
        public virtual DbSet<SACH> SACHes { get; set; }
        public virtual DbSet<TACGIA> TACGIAs { get; set; }
        public virtual DbSet<LIET_KE_CHU_DE> LIET_KE_CHU_DE { get; set; }
        public virtual DbSet<LIET_KE_HOA_DON> LIET_KE_HOA_DON { get; set; }
        public virtual DbSet<LIET_KE_SACH> LIET_KE_SACH { get; set; }
    
        public virtual int IN_SACH(string iDCD)
        {
            var iDCDParameter = iDCD != null ?
                new ObjectParameter("IDCD", iDCD) :
                new ObjectParameter("IDCD", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("IN_SACH", iDCDParameter);
        }
    
        public virtual int SUA_SACH(string mA, string tEN, string hINH, string dIS, Nullable<decimal> gIA, string mAC, string mAN, Nullable<System.DateTime> nAM, string mAT)
        {
            var mAParameter = mA != null ?
                new ObjectParameter("MA", mA) :
                new ObjectParameter("MA", typeof(string));
    
            var tENParameter = tEN != null ?
                new ObjectParameter("TEN", tEN) :
                new ObjectParameter("TEN", typeof(string));
    
            var hINHParameter = hINH != null ?
                new ObjectParameter("HINH", hINH) :
                new ObjectParameter("HINH", typeof(string));
    
            var dISParameter = dIS != null ?
                new ObjectParameter("DIS", dIS) :
                new ObjectParameter("DIS", typeof(string));
    
            var gIAParameter = gIA.HasValue ?
                new ObjectParameter("GIA", gIA) :
                new ObjectParameter("GIA", typeof(decimal));
    
            var mACParameter = mAC != null ?
                new ObjectParameter("MAC", mAC) :
                new ObjectParameter("MAC", typeof(string));
    
            var mANParameter = mAN != null ?
                new ObjectParameter("MAN", mAN) :
                new ObjectParameter("MAN", typeof(string));
    
            var nAMParameter = nAM.HasValue ?
                new ObjectParameter("NAM", nAM) :
                new ObjectParameter("NAM", typeof(System.DateTime));
    
            var mATParameter = mAT != null ?
                new ObjectParameter("MAT", mAT) :
                new ObjectParameter("MAT", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SUA_SACH", mAParameter, tENParameter, hINHParameter, dISParameter, gIAParameter, mACParameter, mANParameter, nAMParameter, mATParameter);
        }
    
        public virtual int THEM_SACH(string mA, string tEN, string hINH, string dIS, Nullable<decimal> gIA, string mAC, string mAN, Nullable<System.DateTime> nAM, string mAT)
        {
            var mAParameter = mA != null ?
                new ObjectParameter("MA", mA) :
                new ObjectParameter("MA", typeof(string));
    
            var tENParameter = tEN != null ?
                new ObjectParameter("TEN", tEN) :
                new ObjectParameter("TEN", typeof(string));
    
            var hINHParameter = hINH != null ?
                new ObjectParameter("HINH", hINH) :
                new ObjectParameter("HINH", typeof(string));
    
            var dISParameter = dIS != null ?
                new ObjectParameter("DIS", dIS) :
                new ObjectParameter("DIS", typeof(string));
    
            var gIAParameter = gIA.HasValue ?
                new ObjectParameter("GIA", gIA) :
                new ObjectParameter("GIA", typeof(decimal));
    
            var mACParameter = mAC != null ?
                new ObjectParameter("MAC", mAC) :
                new ObjectParameter("MAC", typeof(string));
    
            var mANParameter = mAN != null ?
                new ObjectParameter("MAN", mAN) :
                new ObjectParameter("MAN", typeof(string));
    
            var nAMParameter = nAM.HasValue ?
                new ObjectParameter("NAM", nAM) :
                new ObjectParameter("NAM", typeof(System.DateTime));
    
            var mATParameter = mAT != null ?
                new ObjectParameter("MAT", mAT) :
                new ObjectParameter("MAT", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("THEM_SACH", mAParameter, tENParameter, hINHParameter, dISParameter, gIAParameter, mACParameter, mANParameter, nAMParameter, mATParameter);
        }
    
        public virtual int TIM_THEO_NXB(string nXB)
        {
            var nXBParameter = nXB != null ?
                new ObjectParameter("NXB", nXB) :
                new ObjectParameter("NXB", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("TIM_THEO_NXB", nXBParameter);
        }
    
        public virtual int TIM_THEO_TAC_GIA(string tACGIA)
        {
            var tACGIAParameter = tACGIA != null ?
                new ObjectParameter("TACGIA", tACGIA) :
                new ObjectParameter("TACGIA", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("TIM_THEO_TAC_GIA", tACGIAParameter);
        }
    
        public virtual int TIM_THEO_TEN(string tEN)
        {
            var tENParameter = tEN != null ?
                new ObjectParameter("TEN", tEN) :
                new ObjectParameter("TEN", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("TIM_THEO_TEN", tENParameter);
        }
    
        public virtual int XOA_SACH(string mA)
        {
            var mAParameter = mA != null ?
                new ObjectParameter("MA", mA) :
                new ObjectParameter("MA", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("XOA_SACH", mAParameter);
        }
    }
}
