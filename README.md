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

1. Install Software yang Dibutuhkan Sebelum menjalankan project, pastikan sudah menginstall: Visual Studio Code .NET SDK
2. Buka VS Code Klik: File → Open Folder, Pilih folder project ASP.NET Core
3. lalu buat folder dan juga class sesuai dengan kebutuhan projek kita
4. jangan lupa untuk menyeting projek kita agar tersambung ke database yaitu pada settinga json dengan menambahkan nama db yang telah dibuat dan juga pw dari db
5. lalu run dengen mengklik tombol warna hijau berbentuk segitika miring https
6. setelah itu maka akan terbuka link https swagger dari projek yang sudh dibuat 

## cara import database
1. Buka pgAdmin
2. Login ke server PostgreSQL
3. Klik kanan Databases Pilih Create → Database
Isi nama database (misal: TOKO_DB)
Import file .sql
4. Klik database yang tadi dibuat Klik: Tools → Query Tool Klik ikon folder (Open File) Pilih file
database.sql Klik tombol Execute 

##  Daftar Endpoint API
| Method | URL                | Keterangan                      |
|--------|--------------------|---------------------------------|
| GET    | /api/products      | Mengambil semua data produk     |
| GET    | /api/products/{id} | Mengambil produk berdasarkan ID |
| POST   | /api/products      | Menambahkan produk baru         |
| PUT    | /api/products/{id} | Mengupdate produk               |
| DELETE | /api/products/{id} | Menghapus produk                |

link vidio: https://youtu.be/NGur0W285I8?si=w3y_tk8axkzw8lxa
