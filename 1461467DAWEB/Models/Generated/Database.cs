




















// This file was automatically generated by the PetaPoco T4 Template
// Do not make changes directly to this file - edit the template instead
// 
// The following connection settings were used to generate this file
// 
//     Connection String Name: `ShopConnection`
//     Provider:               `System.Data.SqlClient`
//     Connection String:      `Data Source=DESKTOP-AL6E44R;Initial Catalog=ShopBanHang;Integrated Security=True`
//     Schema:                 ``
//     Include Views:          `False`



using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PetaPoco;

namespace ShopConnection
{

	public partial class ShopConnectionDB : Database
	{
		public ShopConnectionDB() 
			: base("ShopConnection")
		{
			CommonConstruct();
		}

		public ShopConnectionDB(string connectionStringName) 
			: base(connectionStringName)
		{
			CommonConstruct();
		}
		
		partial void CommonConstruct();
		
		public interface IFactory
		{
			ShopConnectionDB GetInstance();
		}
		
		public static IFactory Factory { get; set; }
        public static ShopConnectionDB GetInstance()
        {
			if (_instance!=null)
				return _instance;
				
			if (Factory!=null)
				return Factory.GetInstance();
			else
				return new ShopConnectionDB();
        }

		[ThreadStatic] static ShopConnectionDB _instance;
		
		public override void OnBeginTransaction()
		{
			if (_instance==null)
				_instance=this;
		}
		
		public override void OnEndTransaction()
		{
			if (_instance==this)
				_instance=null;
		}
        

		public class Record<T> where T:new()
		{
			public static ShopConnectionDB repo { get { return ShopConnectionDB.GetInstance(); } }
			public bool IsNew() { return repo.IsNew(this); }
			public object Insert() { return repo.Insert(this); }

			public void Save() { repo.Save(this); }
			public int Update() { return repo.Update(this); }

			public int Update(IEnumerable<string> columns) { return repo.Update(this, columns); }
			public static int Update(string sql, params object[] args) { return repo.Update<T>(sql, args); }
			public static int Update(Sql sql) { return repo.Update<T>(sql); }
			public int Delete() { return repo.Delete(this); }
			public static int Delete(string sql, params object[] args) { return repo.Delete<T>(sql, args); }
			public static int Delete(Sql sql) { return repo.Delete<T>(sql); }
			public static int Delete(object primaryKey) { return repo.Delete<T>(primaryKey); }
			public static bool Exists(object primaryKey) { return repo.Exists<T>(primaryKey); }
			public static bool Exists(string sql, params object[] args) { return repo.Exists<T>(sql, args); }
			public static T SingleOrDefault(object primaryKey) { return repo.SingleOrDefault<T>(primaryKey); }
			public static T SingleOrDefault(string sql, params object[] args) { return repo.SingleOrDefault<T>(sql, args); }
			public static T SingleOrDefault(Sql sql) { return repo.SingleOrDefault<T>(sql); }
			public static T FirstOrDefault(string sql, params object[] args) { return repo.FirstOrDefault<T>(sql, args); }
			public static T FirstOrDefault(Sql sql) { return repo.FirstOrDefault<T>(sql); }
			public static T Single(object primaryKey) { return repo.Single<T>(primaryKey); }
			public static T Single(string sql, params object[] args) { return repo.Single<T>(sql, args); }
			public static T Single(Sql sql) { return repo.Single<T>(sql); }
			public static T First(string sql, params object[] args) { return repo.First<T>(sql, args); }
			public static T First(Sql sql) { return repo.First<T>(sql); }
			public static List<T> Fetch(string sql, params object[] args) { return repo.Fetch<T>(sql, args); }
			public static List<T> Fetch(Sql sql) { return repo.Fetch<T>(sql); }
			public static List<T> Fetch(long page, long itemsPerPage, string sql, params object[] args) { return repo.Fetch<T>(page, itemsPerPage, sql, args); }
			public static List<T> Fetch(long page, long itemsPerPage, Sql sql) { return repo.Fetch<T>(page, itemsPerPage, sql); }
			public static List<T> SkipTake(long skip, long take, string sql, params object[] args) { return repo.SkipTake<T>(skip, take, sql, args); }
			public static List<T> SkipTake(long skip, long take, Sql sql) { return repo.SkipTake<T>(skip, take, sql); }
			public static Page<T> Page(long page, long itemsPerPage, string sql, params object[] args) { return repo.Page<T>(page, itemsPerPage, sql, args); }
			public static Page<T> Page(long page, long itemsPerPage, Sql sql) { return repo.Page<T>(page, itemsPerPage, sql); }
			public static IEnumerable<T> Query(string sql, params object[] args) { return repo.Query<T>(sql, args); }
			public static IEnumerable<T> Query(Sql sql) { return repo.Query<T>(sql); }

		}

	}
	



    

	[TableName("dbo.BinhLuanSanPham")]



	[PrimaryKey("MaBinhLuan")]




	[ExplicitColumns]

    public partial class BinhLuanSanPham : ShopConnectionDB.Record<BinhLuanSanPham>  
    {



		[Column] public int MaBinhLuan { get; set; }





		[Column] public int? MaSanPham { get; set; }





		[Column] public string EmailBinhLuan { get; set; }





		[Column] public int? TinhTrang { get; set; }





		[Column] public DateTime? Ngay { get; set; }



	}

    

	[TableName("dbo.DanhSachHinh")]



	[PrimaryKey("MaHinh")]




	[ExplicitColumns]

    public partial class DanhSachHinh : ShopConnectionDB.Record<DanhSachHinh>  
    {



		[Column] public int MaHinh { get; set; }





		[Column] public string TenHinh { get; set; }





		[Column] public int? IdHinh { get; set; }



	}

    

	[TableName("dbo.GioHang")]



	[PrimaryKey("MaGioHang")]




	[ExplicitColumns]

    public partial class GioHang : ShopConnectionDB.Record<GioHang>  
    {



		[Column] public int MaGioHang { get; set; }





		[Column] public int? MaSanPham { get; set; }





		[Column] public int? MaTaiKhoan { get; set; }





		[Column] public int? SoLuong { get; set; }



	}

    

	[TableName("dbo.HangSanXuat")]



	[PrimaryKey("MaHangSanXuat")]




	[ExplicitColumns]

    public partial class HangSanXuat : ShopConnectionDB.Record<HangSanXuat>  
    {



		[Column] public int MaHangSanXuat { get; set; }





		[Column] public string TenHangSanXuat { get; set; }



	}

    

	[TableName("dbo.LoaiSanPham")]



	[PrimaryKey("LoaiSanPham")]




	[ExplicitColumns]

    public partial class LoaiSanPham : ShopConnectionDB.Record<LoaiSanPham>  
    {



		[Column("LoaiSanPham")] public int _LoaiSanPham { get; set; }





		[Column] public string TenLoaiSanPham { get; set; }



	}

    

	[TableName("dbo.SanPham")]



	[PrimaryKey("MaSanPham")]




	[ExplicitColumns]

    public partial class SanPham : ShopConnectionDB.Record<SanPham>  
    {



		[Column] public int MaSanPham { get; set; }





		[Column] public string TenSanPham { get; set; }





		[Column] public decimal? Gia { get; set; }





		[Column] public decimal? GiamGia { get; set; }





		[Column] public string TenHinh { get; set; }





		[Column] public string MoTa { get; set; }





		[Column] public int? LoaiSp { get; set; }





		[Column] public int? HangSx { get; set; }



	}

    

	[TableName("dbo.sysdiagrams")]



	[PrimaryKey("diagram_id")]




	[ExplicitColumns]

    public partial class sysdiagram : ShopConnectionDB.Record<sysdiagram>  
    {



		[Column] public string name { get; set; }





		[Column] public int principal_id { get; set; }





		[Column] public int diagram_id { get; set; }





		[Column] public int? version { get; set; }





		[Column] public byte[] definition { get; set; }



	}


}
