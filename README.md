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
1. Install Software yang Dibutuhkan Sebelum menjalankan project, pastikan sudah menginstall: Visual Studio Code, .NET SDK
2. setelah melakukan install visual studio create new projek lalu memilih asp net core web api lalu beri nama projek yang akna kita buat
3. setelah itu tambahkan folder dan class apa saja yang dibutahkan oleh projek yang akan dibuat. contohnya pada projek saya
   - folder controllers ada class produkControllers.cs
   - Folder models ada class orderr.cs, produk.cs, customers.cs
   - folder data
   - folder appjson yang dimana untuk menghubungkan database dna juga visual studio
4. setelah itu bisa klik run untuk menjalankan projek
5. lalu klik link https swagger untuk projek yang sudah dibuat
---
## import database
1. Buka pgAdmin
2. Login ke server PostgreSQL
3. Klik kanan Databases Pilih: Create → Database Isi nama database (misal: TOKO_DB), Import file .sql
3. Klik database yang tadi dibuat Klik: Tools → Query Tool
4. Klik ikon folder (Open File) Pilih file: database.sql
5. Klik tombol Execute
---
##  Daftar Endpoint API
| Method | URL                | Keterangan                      |
|--------|--------------------|---------------------------------|
| GET    | /api/products      | Mengambil semua data produk     |
| GET    | /api/products/{id} | Mengambil produk berdasarkan ID |
| POST   | /api/products      | Menambahkan produk baru         |
| PUT    | /api/products/{id} | Mengupdate produk               |
| DELETE | /api/products/{id} | Menghapus produk                |

link Youtube: https://youtu.be/NGur0W285I8?si=w3y_tk8axkzw8lxa
