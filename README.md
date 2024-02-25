# CSharp-Applications

## CSharpLearn

Bu C# öğrenme rehberi, farklı temel konuları içeren örnek kodları içerir. Her bir konu ayrı bir alt dizinde bulunur ve o konuya özgü örnekler içerir.

### Konular ve İçerikler
- Arrays (Diziler): Dizilerle ilgili temel işlemleri içerir.
- Classes (Sınıflar): Sınıfların nasıl tanımlanıp kullanılacağını gösterir.
- Conditionals (Koşullu İfadeler): If-else ve switch-case gibi koşullu ifadelerin kullanımını içerir.
- Constructors (Kurucular): Kurucu metotların kullanımını içerir.
- Generics (Jenerikler): Jenerik (generic) yapıların kullanımını içerir.
- Inheritance (Kalıtım): Sınıflar arasında kalıtım ilişkilerinin nasıl kurulduğunu gösterir.
- Interfaces (Arayüzler): Arayüzlerin nasıl tanımlanıp uygulandığını gösterir.
- Interfaces2 (Arayüzler 2): Arayüzlerin daha gelişmiş kullanımlarını içerir.
- InterfacesDemo (Arayüzler Örneği): Arayüzlerin kullanımına ilişkin detaylı örnekler içerir.
- LinqProject (Linq Projesi): Language Integrated Query (LINQ) kullanımını içerir.
- Loops (Döngüler): For, while ve do-while döngülerinin kullanımını içerir.
- Methods (Metotlar): Metodların tanımlanması ve kullanımını içerir.
- RecapDemo1 (Tekrar Örneği 1): Öğrenilen konuların bir araya getirilerek uygulandığı örnekler içerir.
- ReferenceTypes (Referans Tipleri): Referans türlerinin kullanımını içerir.
- Strings (Karakter Dizileri): String veri tipinin kullanımını içerir.
- ThreadingDemo_1 (Eş Zamanlılık Örneği 1): Asenkron programlama ve eş zamanlılık (threading) konularını içerir.
- TypesAndVariables (Tipler ve Değişkenler): Değişken tanımlama ve farklı veri tiplerini içerir.

### Nasıl Kullanılır?
1. İlgili konuyu seçin ve alt dizine gidin.
2. İlgili örnekleri açın ve kodları inceleyin.
3. Her örneği çalıştırarak sonuçları gözlemleyin.

** Bu rehber, C# programlama dilini öğrenmek isteyenler için temel kavramların anlaşılmasına yardımcı olmak amacıyla oluşturulmuştur. **

## Intro

Bu C# konsol uygulaması, basit bir örnek sunar ve başlangıç seviyesi C# programlama kavramlarını içerir. Uygulama, "Hello, World!" gibi basit bir çıktıdan başlayarak, değişkenlerin tanımlanması, koşullu ifadelerin kullanımı, döngülerin ve sınıfların oluşturulması gibi temel konuları kapsar.

### Kod İçeriği ve Açıklamaları
- Main metodu, programın giriş noktasını oluşturur ve uygulamanın ana iş mantığını içerir.
- Değişkenlerin tanımlanması ve kullanımı temsil edilir: string, int, double ve bool.
- if-else koşullu ifadeleri, kullanıcının kimlik doğrulamasını simüle etmek için kullanılır.
- Diziler (Arrays) kullanılarak kredi türleri saklanır ve bir döngü aracılığıyla ekrana yazdırılır.
- Bir sınıf olan Course, kurs bilgilerini içerir: kimlik (Id), isim (Name), açıklama (Description) ve fiyat (Price).
- Kursların bir listesi oluşturulur ve bu liste döngü aracılığıyla ekrana yazdırılır.
- CourseManager sınıfı, kurslarla ilgili işlemleri gerçekleştirmek için kullanılır. GetAll metodu, tüm kursları döndürür.
- Müşterileri temsil eden IndividualCustomer ve CorporateCustomer sınıfları tanımlanır ve bu sınıflardan nesneler oluşturulur.
- Değer atama işlemleri ve referans tiplerin (array, class, interface) davranışı incelenir.
- Polimorfizm kullanılarak, müşteri bilgileri ekrana yazdırılır.

### Nasıl Çalıştırılır?
1. Projeyi bir C# geliştirme ortamında (örneğin, Visual Studio veya Visual Studio Code) açın.
2. Program.cs dosyasını açın.
3. Projeyi derleyin ve çalıştırın.
4. Konsol çıktısında, programın çalışmasıyla ilgili bilgileri göreceksiniz.

Bu uygulama, C# programlama dilini anlamak ve temel kavramları uygulamak için iyi bir başlangıç ​​noktasıdır.


## MaskeTakip Uygulaması

Bu C# konsol uygulaması, maskelerin dağıtımını takip etmek için basit bir örnek sunar. Uygulama, bir kişi nesnesi oluşturarak ve bu nesneyi bir yönetici sınıfına ileterek gerçekleştirilen temel bir maskelerin dağıtım sürecini simüle eder. Ayrıca, temel C# programlama kavramlarını içerir ve aşağıdaki özellikleri kapsar:

- Metotlar (Methods)
- Diziler (Arrays)
- Sınıflar (Classes)
- Nesne Oluşturma (Object Creation)
- Döngüler (Loops)
- Listeler (Lists)

### Kod İçeriği ve Açıklamaları

- Main metodu, programın giriş noktasını oluşturur. Bu metot, uygulamanın ana iş mantığını içerir.
- SelamVer ve Topla adında iki yardımcı metot, kullanıcıya selam vermek ve verilen iki sayıyı toplamak için kullanılır.
- Diziler (Arrays) kullanılarak öğrenci isimleri saklanır ve döngüler (Loops) aracılığıyla bu isimler ekrana yazdırılır.
- Person sınıfı, bir kişinin temel bilgilerini içerir: ad, soyad, doğum yılı ve TC kimlik numarası.
- List koleksiyonu kullanılarak şehirler listesi oluşturulur ve bu liste ekrana yazdırılır.
- PttManager ve PersonManager sınıfları, maskelerin dağıtımını yönetmek için kullanılır. GiveMask metodu, bir kişiye maske verme işlemini simüle eder.

### Nasıl Çalıştırılır?

1. Projeyi bir C# geliştirme ortamında (örneğin, Visual Studio veya Visual Studio Code) açın.
2. Program.cs dosyasını açın.
3. Projeyi derleyin ve çalıştırın.
4. Konsol çıktısında, programın çalışmasıyla ilgili bilgileri göreceksiniz.

Uygulama, temel C# programlama kavramlarını anlamak ve uygulamak için iyi bir örnek teşkil eder.

## Eğitim Platformu Veritabanı Simülasyonu

Bu proje, bir eğitim platformunda kurslar, eğitmenler ve kategorilerin veritabanı işlemlerini simüle etmektedir.

### Genel Bakış

Proje şu bileşenleri içermektedir:

- Business Layer: Kurslar, eğitmenler ve kategorileri yönetmek için iş mantığı işlevselliğini içerir.

- Data Access Layer: Veritabanıyla etkileşim için veri erişim işlevselliğini sağlar.

- Entities: Kurslar, eğitmenler ve kategoriler için varlık sınıflarını tanımlar.

### Kullanım
Proje, her bir varlık için temel CRUD (Add, Update, Delete) işlemlerini gösterir:

#### Kurslar
- Tüm kursları listeleme.
- Yeni bir kurs eklemek.
- Mevcut bir kursu güncelleme.
- Bir kursu silme.

#### Eğitmenler
- Tüm eğitmenleri listeleme.
- Yeni eğitmenler eklemek.
- Mevcut eğitmenleri güncelleme.
- Bir eğitmeni silme.

#### Kategoriler
- Tüm kategorileri listeleme.
- Yeni kategoriler eklemek.
- Mevcut kategorileri güncelleme.
- Bir kategoriyi silme.


### Nasıl Çalıştırılır?

- Bu repoyu yerel makinenize klonlayın.

- Çözüm dosyasını (EducationalPlatformDBSimulation.sln) Visual Studio veya uyumlu bir IDE'de açın.

- Çözümü derleyin ve projeyi çalıştırın.

Bu proje bir simülasyondur ve gerçek bir veritabanı ile etkileşime geçmez. Simüle bir ortam kullanarak veritabanı yönetimi kavramlarını göstermek amacıyla tasarlanmıştır.


## WebApi
Bu Web API projesi, marka bilgilerini yönetmek için bir arayüz sağlar.

### Genel Bakış
Bu proje, farklı markaların eklenmesi için temel CRUD işlemlerinden olan (Add) gerçekleştiren bir API sunar.

### Proje Yapısı
Proje aşağıdaki katmanlardan oluşmaktadır:

- Entities: Veritabanı varlıklarını (örneğin, marka) içerir.

- DataAccess: Veritabanı işlemlerini yöneten veri erişim katmanını içerir.

- Business: İş mantığı işlevselliğini yöneten iş katmanını içerir.

- WebApi: HTTP isteklerini karşılayan ve API rotalarını yöneten Web API katmanını içerir.

- Core: Ortak ve paylaşılan bileşenleri içerir.

### Servisler
Proje, iş mantığı işlevselliğini ve veri erişimini sağlayan servisleri içerir:

- IBrandService: Marka işlemlerini yönetmek için soyut bir arayüz sağlar.

- BrandManager: Marka işlemlerini gerçekleştiren iş mantığı katmanıdır.

- IBrandDal: Veritabanı işlemlerini yönetmek için soyut bir arayüz sağlar.

- BrandDal: Veritabanı işlemlerini gerçekleştiren veri erişim katmanıdır.

### Nasıl Çalıştırılır?
- Proje dosyalarınızı klonlayın veya indirin.

- Projeyi bir geliştirme ortamında (örneğin, Visual Studio veya Visual Studio Code) açın.

- Projeyi derleyin ve çalıştırın.

- API'ye istekler göndererek ve Swagger arayüzünü kullanarak API'yi test edin.


Proje geliştirme aşamasındadır ve güvenliği veya performansı garanti etmez.
