# Tubes2Stima-FolderCrawler

Tugas Besar II IF2211 Strategi Algoritma <br>
Pemanfaatan Algoritma _DFS_ dan _BFS_ dalam Aplikasi "Folder Crawler" <br>
Semester II 2021/2022

# Deskripsi Singkat

Folder Crawler adalah aplikasi yang digunakan untuk mencari satu atau seluruh file spesifik yang terletak pada suatu direktori. Algoritma _DFS_ atau _BFS_ digunakan untuk mencari file query dengan menelusuri direktori dimulai dari _root_ hingga seluruh _children_ dari _root_ hingga satu file pertama atau seluruh file ditemukan. Ada pula kemungkinan file tidak ditemukan sama sekali.

Algoritma _DFS_ memiliki prioritas untuk mencari folder di dalam folder terlebih dahulu hingga tidak ada lagi folder di dalam _child_-nya, sementara algoritma _BFS_ akan mengiterasi seluruh file dan folder dalam satu aras. setelah seluruhnya dicari dan tidak ditemukan, maka dilanjutkan dengan mengiterasi seluruh file pada seluruh folder pada aras tersebut (membentuk aras baru).

# Requirements Program
1. [.NET Framework 4.7.2](https://dotnet.microsoft.com/en-us/download/dotnet-framework)
2. Tugas dibuat dalam IDE `Microsoft Visual Studio Community 2022 (64-bit) Version 17.1.0` sehingga file `.sln` dapat dibuka pada IDE yang bersangkutan
3. File `.exe` di-_build_ dan dapat dicoba pada Sistem Operasi Windows 10 dan 11.

# Cara Menggunakan Program
0. Download dan ekstrak zip dari repository ini ke folder bebas;
1. Apabila ingin melakukan build ulang file `.sln`, dapat membuka `Visual Studio IDE`, navigasi menu Build > Build Solution. Output `.exe` terletak pada folder `/bin`;
2. Jalankan `Tubes2Stima-DeathFromStima-FolderCrawler.exe`;
3. Pilih Folder sebagai _starting directory_ melalui menu `Choose Folder`;
4. Masukkan nama file beserta ekstensinya yang akan dicari;
5. Pilih algoritma/metode pencarian yang diinginkan (DFS atau BFS);
6. (Opsional) Centang _check box_ `Find All File Occurance` bila ingin mencari seluruh file dengan nama yang sudah dimasukkan;
7. Klik tombol `Search` untuk memulai pencarian;
8. Pohon hasil pencarian akan muncul, beserta _hyperlink_ (daftar _hyperlink_) menuju folder letak file yang sedang dicari;
9 Klik tombol `Reset input` untuk melakukan pencarian baru.

# Author
Kelompok 46 - DeathFromStima

| NIM      | NAMA                       |
|----------|----------------------------|
| 13520003 | Dzaky Fattan Rizqullah     | 
| 13520018 | Bariza Haqi                | 
| 13520159 | Atabik Muhammad Azfa Shofi | 