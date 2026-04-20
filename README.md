#  REST API Toko (TugasTM1)

## Deskripsi Project
Project ini merupakan REST API sederhana dengan tema **Toko** yang dibuat untuk memenuhi tugas LKM.  
API ini digunakan untuk mengelola data produk dengan operasi CRUD (Create, Read, Update, Delete).

Selain itu, database yang digunakan terdiri dari 3 tabel yang saling berelasi yaitu:
- customers
- products
- orders

Relasi terdapat pada tabel orders yang menghubungkan customers dan products melalui foreign key.

---

##  Teknologi yang Digunakan
- Bahasa Pemrograman: C#
- Framework: ASP.NET Core Web API
- Database: PostgreSQL
- ORM: Entity Framework Core
- Tools: Visual Studio, pgAdmin

---

##  Cara Instalasi & Menjalankan Project

1. Clone repository ini atau download project
2. Buka project di Visual Studio
3. Pastikan PostgreSQL sudah aktif
4. Atur connection string di file `appsettings.json`:
{
  "ConnectionStrings": {
    "DefaultConnection": "Host=localhost;Port=5432;Database=TOKO_DB;Username=postgres;Password=101005"
  }
}

##  Daftar Endpoint API
| Method | URL                | Keterangan                      |
|--------|--------------------|---------------------------------|
| GET    | /api/products      | Mengambil semua data produk     |
| GET    | /api/products/{id} | Mengambil produk berdasarkan ID |
| POST   | /api/products      | Menambahkan produk baru         |
| PUT    | /api/products/{id} | Mengupdate produk               |
| DELETE | /api/products/{id} | Menghapus produk                |
