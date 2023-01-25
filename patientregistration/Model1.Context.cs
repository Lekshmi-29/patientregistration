﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace patientregistration
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class clinicEntities : DbContext
    {
        public clinicEntities()
            : base("name=clinicEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<detailtab> detailtabs { get; set; }
    
        public virtual int sp_insert(string na, string ad, string pin, string aad, string mob, string bg, string vd, string pov)
        {
            var naParameter = na != null ?
                new ObjectParameter("na", na) :
                new ObjectParameter("na", typeof(string));
    
            var adParameter = ad != null ?
                new ObjectParameter("ad", ad) :
                new ObjectParameter("ad", typeof(string));
    
            var pinParameter = pin != null ?
                new ObjectParameter("pin", pin) :
                new ObjectParameter("pin", typeof(string));
    
            var aadParameter = aad != null ?
                new ObjectParameter("aad", aad) :
                new ObjectParameter("aad", typeof(string));
    
            var mobParameter = mob != null ?
                new ObjectParameter("mob", mob) :
                new ObjectParameter("mob", typeof(string));
    
            var bgParameter = bg != null ?
                new ObjectParameter("bg", bg) :
                new ObjectParameter("bg", typeof(string));
    
            var vdParameter = vd != null ?
                new ObjectParameter("vd", vd) :
                new ObjectParameter("vd", typeof(string));
    
            var povParameter = pov != null ?
                new ObjectParameter("pov", pov) :
                new ObjectParameter("pov", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_insert", naParameter, adParameter, pinParameter, aadParameter, mobParameter, bgParameter, vdParameter, povParameter);
        }
    
        public virtual int sp_login(string na, string mob, ObjectParameter status)
        {
            var naParameter = na != null ?
                new ObjectParameter("na", na) :
                new ObjectParameter("na", typeof(string));
    
            var mobParameter = mob != null ?
                new ObjectParameter("mob", mob) :
                new ObjectParameter("mob", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_login", naParameter, mobParameter, status);
        }
    
        public virtual ObjectResult<sp_search_Result> sp_search(string na)
        {
            var naParameter = na != null ?
                new ObjectParameter("na", na) :
                new ObjectParameter("na", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_search_Result>("sp_search", naParameter);
        }
    
        public virtual int sp_Editing(string na, string ad, string pin, string aad, string mob, string bg, string vd, string pov)
        {
            var naParameter = na != null ?
                new ObjectParameter("na", na) :
                new ObjectParameter("na", typeof(string));
    
            var adParameter = ad != null ?
                new ObjectParameter("ad", ad) :
                new ObjectParameter("ad", typeof(string));
    
            var pinParameter = pin != null ?
                new ObjectParameter("pin", pin) :
                new ObjectParameter("pin", typeof(string));
    
            var aadParameter = aad != null ?
                new ObjectParameter("aad", aad) :
                new ObjectParameter("aad", typeof(string));
    
            var mobParameter = mob != null ?
                new ObjectParameter("mob", mob) :
                new ObjectParameter("mob", typeof(string));
    
            var bgParameter = bg != null ?
                new ObjectParameter("bg", bg) :
                new ObjectParameter("bg", typeof(string));
    
            var vdParameter = vd != null ?
                new ObjectParameter("vd", vd) :
                new ObjectParameter("vd", typeof(string));
    
            var povParameter = pov != null ?
                new ObjectParameter("pov", pov) :
                new ObjectParameter("pov", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_Editing", naParameter, adParameter, pinParameter, aadParameter, mobParameter, bgParameter, vdParameter, povParameter);
        }
    
        public virtual int sp_update(string na, string vd, string pov)
        {
            var naParameter = na != null ?
                new ObjectParameter("na", na) :
                new ObjectParameter("na", typeof(string));
    
            var vdParameter = vd != null ?
                new ObjectParameter("vd", vd) :
                new ObjectParameter("vd", typeof(string));
    
            var povParameter = pov != null ?
                new ObjectParameter("pov", pov) :
                new ObjectParameter("pov", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_update", naParameter, vdParameter, povParameter);
        }
    
        public virtual ObjectResult<sp_delete_Result> sp_delete(string na)
        {
            var naParameter = na != null ?
                new ObjectParameter("na", na) :
                new ObjectParameter("na", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_delete_Result>("sp_delete", naParameter);
        }
    }
}