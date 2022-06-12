
# Building Managment System




## Proje İçeriği

    Proje bina yönetimi için geliştilmiştir.Küçük ve orta ölçekli sitelerin içerisinde yer alan dairelerin
    aidat ortak kullanım elektrik, su ve doğalgaz faturalarının yönetimini ayrıca
    bina içerisinde kiracı veya ev sahipleri bilgilerinin tutulması gibi özellikler içermektedir.

## API Nedir ?
    API, Türkçede “Uygulama Programlama Arayüzü” anlamına gelen “Application Programming Interface” tanımının baş harflerinden ortaya çıkmış bir terimdir. Kısa bir tanımla API, kendine ait veriler ve çalışma prensipleri ile geliştirilmiş uygulamaların, birbirileri ile iletişime geçerek çalışmasını mümkün kılan yazılımdır.


##	Projende kullanılan Teknoloji ve Patternler

    Projenin database kısmı SQL Server içermektedir. Projenin backend kısmında .Net Core 5 kullanılarak geliştirilmiştir.
    Projede UnitofWork patterni Automapper ve token için JWTToken kullanılmıştır. Mail servisleri için yandex mail kullanılmıştır.
    Projenin frontend kısmı React Framework'ü ile kodlanmıştır.

## Projede Kullanılan Kavramlar

-	N-Katmanlı Mimari tasarımı(sunum, servis, entity, iş katmanı, dal katmanı)
-	OOP(class, nesne, interface, kalıtım, çoklu kalıtım, yapıcı metod, kapsülleme)
-	ORM-Entityframework
-	Mapper yapısı kurma ve kullanma
-	Transaction yönetimi(UnitOfWork pattern)
-	Repository,gereric repository pattern
-	Generic metod, generic class, generic interface
-	Depency injeciton
-	JWTToken dağıtma ve kullanma
-	REST Api tasarımı
-	Web Api Setup ayarları
-	UML oluşturma
-	UML’i okuyarak veri tabanı oluşturma
-	Veri tabanı:Tablo, Kolon, Primary Key , Foreign Key, Unique key
-   HTML
-   CSS
-   Boostrap
-   React

## API Özellikleri

#### User Login:
- Database tarafında kaydedilmiş olan kullanıcının mail ve password onayından sonra token üreterek sisteme girişinin sağlanması.
#### Manager Login:
- Database tarafında kaydedilmiş olan kullanıcının mail ve password onayından sonra token üreterek sisteme girişinin sağlanması.
#### User:
- CRUD işlemleri (Create, Read, Update, Delete )
- ID ye göre User özelliklerinin getirilmesi
- Parola Değiştirme
#### Manager:
- CRUD işlemleri (Create, Read, Update, Delete )
- Manager tarafından User daire ve fatura eklenmesi
#### Apartment:
- CRUD işlemleri (Create, Read, Update, Delete )
- ID ye göre dailenin özelliklerinin getirilmesi
- Yönetici tarafından daire eklenmesi işlemi
- Site Id sine göre site içerisindeki apartmanların getirilmesi.
- Managerin yöneticiliğini yaptığı siteleri getirilmesi.
#### Message:
- CRUD işlemleri (Create, Read, Update, Delete )
- ID ye göre Message özelliklerinin getirilmesi
- Yazışmalarının listelenmesi
#### Invoince:
- CRUD işlemleri (Create, Read, Update, Delete )
- ID ye göre Invoince özelliklerinin getirilmesi

  
## Kullanılan Teknolojiler

**Backend :** ASP .NET CORE:

**VeriTabanı:** Microsoft SQL Server

**Frontend:** HTML JS CSS Boostrap React

**Dökümantasyon:** Swagger - Postman

## API Kullanımı
    Kullanıcı Admin veya Yönetici girişi yapılmalıdır. Giriş Yapıldıktan sonra sistem tarafından verilen Token, Authorize kısmına kaydedilmelmektedir. Api ye gönderilecek olan işlemler bu aşamadan sonra gerçekleştirilmelidir.

### ManagerLogin

#### Post  ManagerLogin

```http
  POST /api/ManagerLogin/Login
```

| Parametre | Tip     | Açıklama                |
| :-------- | :------- | :------------------------- |
| `managerMail` | `string` | **Gerekli** Manager/Admin Gmail |
| `managerPass` | `string` | **Gerekli** Manager/Admin Parola |

```json
{
  "managerMail": "user@example.com",
  "managerPass": "string"
}
```

### UserLogin

#### Post  UserLogin

```http
  POST /api/UserLogin/Login
```

| Parametre | Tip     | Açıklama                |
| :-------- | :------- | :------------------------- |
| `userEmail` | `string` | **Gerekli** Employee Gmail |
| `userPass` | `string` | **Gerekli** Employee Parola |

```json
{
  "userEmail": "user@example.com",
  "userPass": "string"
}
```
### Apartment

#### GET FindID

```http
  GET /api/Apartment/Find?id=1
```

| Parametre | Tip     | Açıklama                |
| :-------- | :------- | :------------------------- |
| `apartment` | `int` | **Gerekli** Apartment ID |

#### GET FindApartment

```http
  GET /api/Apartment/FindApartment?managerid=1
```

| Parametre | Tip     | Açıklama                |
| :-------- | :------- | :------------------------- |
| `findApartment` | `int` | **Gerekli** Apartment ID |

#### GET GetAll

```http
  GET /api/Apartment/GetAll
```

#### Post Add

```http
  POST /api/Apartment/Add
```

| Parametre | Tip     | Açıklama                |
| :-------- | :------- | :------------------------- |
| `apartmentId` | `int` | **Gerekli**  Daire ID |
| `buildingsName` | `string` | **Gerekli**  Bina İsmi |
| `apartmentBlock` | `string` | **Gerekli**   Dairenin Bulunduğu sitenin bloğu |
| `apartmentStatus` | `string` | **Gerekli**  Daire Durumu (Dolu,Boş) |
| `apartmentType` | `string` | **Gerekli**  Daire Türü (2+1 , 3+1) |
| `apartmentNo` | `string` | **Gerekli**  Daire no |
| `apartmentUser` | `int` | **Gerekli**  Daire Sahibi |
| `apartmentManager` | `int` | **Gerekli**  Daire Yöneticisi |

```json
{
  "apartmentId": 0,
  "buildingsName": "string",
  "apartmentBlock": "string",
  "apartmentStatus": "string",
  "apartmentType": "string",
  "apartmentFlat": "string",
  "apartmentNo": "string",
  "apartmentUser": 0,
  "apartmentManager": 0
}
```
#### DEL Delete

```http
  DEL /api/Apartment/Delete?id=8
```

| Parametre | Tip     | Açıklama                |
| :-------- | :------- | :------------------------- |
| `apartmentId` | `int` | **Gerekli**  Apartment ID |

#### PUT Update

```http
  PUT /api/Apartment/Update
```

| Parametre | Tip     | Açıklama                |
| :-------- | :------- | :------------------------- |
| `apartmentId` | `int` | **Gerekli**  Daire ID |
| `buildingsName` | `string` | **Gerekli**  Bina İsmi |
| `apartmentBlock` | `string` | **Gerekli**   Dairenin Bulunduğu sitenin bloğu |
| `apartmentStatus` | `string` | **Gerekli**  Daire Durumu (Dolu,Boş) |
| `apartmentType` | `string` | **Gerekli**  Daire Türü (2+1 , 3+1) |
| `apartmentNo` | `string` | **Gerekli**  Daire no |
| `apartmentUser` | `int` | **Gerekli**  Daire Sahibi |
| `apartmentManager` | `int` | **Gerekli**  Daire Yöneticisi |

```json
{
  "apartmentId": 0,
  "buildingsName": "string",
  "apartmentBlock": "string",
  "apartmentStatus": "string",
  "apartmentType": "string",
  "apartmentFlat": "string",
  "apartmentNo": "string",
  "apartmentUser": 0,
  "apartmentManager": 0
}
```

### Invoice

#### GET FindID

```http
  GET /api/Invoice/Find?id=1
```

| Parametre | Tip     | Açıklama                |
| :-------- | :------- | :------------------------- |
| `invoiceid` | `int` | **Gerekli** Invoice ID |

#### GET GetAll

```http
  GET /api/Invoice/GetAll
```

#### Post Add

```http
  POST /api/Invoice/Add
```

| Parametre | Tip     | Açıklama                |
| :-------- | :------- | :------------------------- |
| `invoiceId` | `int` | **Gerekli**  Invoice ID |
| `dues` | `string` | **Gerekli**  aidat |
| `commonUsage` | `string` | **Gerekli**  Genel Kullanım |
| `invoiceElectric` | `string` | **Gerekli**  elektrik |
| `invoiceWater` | `string` | **Gerekli**  su |
| `invoiceGas` | `string` | **Gerekli**  Doğal Gaz |
| `manager` | `int` | **Gerekli**  Manager ID |
| `users` | `int` | **Gerekli**  Kullanıcı ID |
| `apartment` | `int` | **Gerekli**  Daire ID |

```json
{
  "invoiceId": 0,
  "dues": "string",
  "commonUsage": "string",
  "invoiceElectric": "string",
  "invoiceWater": "string",
  "invoiceGas": "string",
  "manager": 0,
  "users": 0,
  "apartment": 0
}
```
#### DEL Delete

```http
  DEL /api/Invoice/Delete?id=4
```

| Parametre | Tip     | Açıklama                |
| :-------- | :------- | :------------------------- |
| `invoiceId` | `int` | **Gerekli**  Invoice ID |

#### PUT Update

```http
  POST /api/Invoice/Update
```

| Parametre | Tip     | Açıklama                |
| :-------- | :------- | :------------------------- |
| `invoiceId` | `int` | **Gerekli**  Invoice ID |
| `dues` | `string` | **Gerekli**  aidat |
| `commonUsage` | `string` | **Gerekli**  Genel Kullanım |
| `invoiceElectric` | `string` | **Gerekli**  elektrik |
| `invoiceWater` | `string` | **Gerekli**  su |
| `invoiceGas` | `string` | **Gerekli**  Doğal Gaz |
| `manager` | `int` | **Gerekli**  Manager ID |
| `users` | `int` | **Gerekli**  Kullanıcı ID |
| `apartment` | `int` | **Gerekli**  Daire ID |

```json
{
  "invoiceId": 0,
  "dues": "string",
  "commonUsage": "string",
  "invoiceElectric": "string",
  "invoiceWater": "string",
  "invoiceGas": "string",
  "manager": 0,
  "users": 0,
  "apartment": 0
}
```

### Manager

#### GET FindID

```http
  GET /api/Manager/Find?id=1
```

| Parametre | Tip     | Açıklama                |
| :-------- | :------- | :------------------------- |
| `managerid` | `int` | **Gerekli** Manager ID |

#### GET GetAll

```http
  GET /api/Manager/GetAll
```

#### Post Add

```http
  POST /api/Manager/Add
```

| Parametre | Tip     | Açıklama                |
| :-------- | :------- | :------------------------- |
| `managerId` | `int` | **Gerekli**  Manager ID |
| `managerName` | `string` | **Gerekli**  managerName |
| `managerSurname` | `string` | **Gerekli** managerSurname |
| `managerMail` | `string` | **Gerekli**  managerMail |
| `managerPass` | `string` | **Gerekli**  managerPass |
| `managerPhone` | `string` | **Gerekli** managerPhone |
| `managerTc` | `string` | **Gerekli**  managerTc |
| `role` | `string` | **Gerekli** role |

```json
{
  "managerId": 0,
  "managerName": "string",
  "managerSurname": "string",
  "managerMail": "string",
  "managerPass": "string",
  "managerPhone": "string",
  "managerTc": "string",
  "role": "string"
}
```
#### DEL Delete

```http
  DEL /api/Manager/Delete?id=4
```

| Parametre | Tip     | Açıklama                |
| :-------- | :------- | :------------------------- |
| `managerId` | `int` | **Gerekli**  Manager ID |

#### PUT Update

```http
  POST /api/Invoice/Update
```

| Parametre | Tip     | Açıklama                |
| :-------- | :------- | :------------------------- |
| `managerId` | `int` | **Gerekli**  Manager ID |
| `managerName` | `string` | **Gerekli**  managerName |
| `managerSurname` | `string` | **Gerekli** managerSurname |
| `managerMail` | `string` | **Gerekli**  managerMail |
| `managerPass` | `string` | **Gerekli**  managerPass |
| `managerPhone` | `string` | **Gerekli** managerPhone |
| `managerTc` | `string` | **Gerekli**  managerTc |
| `role` | `string` | **Gerekli** role |

```json
{
  "managerId": 0,
  "managerName": "string",
  "managerSurname": "string",
  "managerMail": "string",
  "managerPass": "string",
  "managerPhone": "string",
  "managerTc": "string",
  "role": "string"
}
```

### Message

#### GET FindID

```http
  GET /api/Message/Find?id=1
```

| Parametre | Tip     | Açıklama                |
| :-------- | :------- | :------------------------- |
| `messageid` | `int` | **Gerekli** Message ID |

#### GET GetAll

```http
  GET /api/Message/GetAll
```

#### Post Add

```http
  POST /api/Message/Add
```

| Parametre | Tip     | Açıklama                |
| :-------- | :------- | :------------------------- |
| `messageId` | `int` | **Gerekli**  Message ID |
| `sender` | `int` | **Gerekli**  Gönderen |
| `receiver` | `int` | **Gerekli** Alıcı |
| `messageTitle` | `string` | **Gerekli**  Mesaj Başlığı |
| `messageBody` | `string` | **Gerekli**  Mesaj İçeriği |
| `messageStatus` | `string` | **Gerekli** Mesaj Durumu |
| `messageTime` | `datetime` | **Gerekli**  Mesaj Saati |

```json
{
  "messageId": 0,
  "sender": 0,
  "receiver": 0,
  "messageTitle": "string",
  "messageBody": "string",
  "messageStatus": "string",
  "messageTime": "2022-06-12T22:59:20.044Z"
}
```
#### DEL Delete

```http
  DEL /api/Message/Delete?id=4
```

| Parametre | Tip     | Açıklama                |
| :-------- | :------- | :------------------------- |
| `messageId` | `int` | **Gerekli**  Message ID |

#### PUT Update

```http
  POST /api/Message/Update
```

| Parametre | Tip     | Açıklama                |
| :-------- | :------- | :------------------------- |
| `messageId` | `int` | **Gerekli**  Message ID |
| `sender` | `int` | **Gerekli**  Gönderen |
| `receiver` | `int` | **Gerekli** Alıcı |
| `messageTitle` | `string` | **Gerekli**  Mesaj Başlığı |
| `messageBody` | `string` | **Gerekli**  Mesaj İçeriği |
| `messageStatus` | `string` | **Gerekli** Mesaj Durumu |
| `messageTime` | `datetime` | **Gerekli**  Mesaj Saati |

```json
{
  "messageId": 0,
  "sender": 0,
  "receiver": 0,
  "messageTitle": "string",
  "messageBody": "string",
  "messageStatus": "string",
  "messageTime": "2022-06-12T22:59:20.044Z"
}
```

### User

#### GET FindID

```http
  GET /api/User/Find?id=1
```

| Parametre | Tip     | Açıklama                |
| :-------- | :------- | :------------------------- |
| `userid` | `int` | **Gerekli** User ID |

#### GET GetAll

```http
  GET /api/User/GetAll
```

#### Post Add

```http
  POST /api/User/Add
```

| Parametre | Tip     | Açıklama                |
| :-------- | :------- | :------------------------- |
| `userId` | `int` | **Gerekli**  User ID |
| `userName` | `int` | **Gerekli**  Kullanıcı Adı |
| `userSurname` | `int` | **Gerekli** Kullanıcı Soyadı |
| `userEmail` | `string` | **Gerekli**  Kullanıcı email |
| `userPass` | `string` | **Gerekli**  Kullanıcı Parola |
| `userPhone` | `string` | **Gerekli** Kullanıcı Telefon |
| `userTc` | `datetime` | **Gerekli**  Kullanıcı TC |
| `userPlate` | `datetime` | **Gerekli**  Kullanıcı Plaka |
| `manager` | `int` | **Gerekli**  Manager ID |
| `userRole` | `datetime` | **Gerekli**  Kullanıcı Role |

```json
{
  "userId": 0,
  "userName": "string",
  "userSurname": "string",
  "userEmail": "string",
  "userPass": "string",
  "userPhone": "string",
  "userTc": "string",
  "userPlate": "string",
  "manager": 0,
  "userRole": "string"
}
```
#### DEL Delete

```http
  DEL /api/User/Delete?id=4
```

| Parametre | Tip     | Açıklama                |
| :-------- | :------- | :------------------------- |
| `userid` | `int` | **Gerekli**  User ID |

#### PUT Update

```http
  POST /api/User/Update
```

| Parametre | Tip     | Açıklama                |
| :-------- | :------- | :------------------------- |
| `userId` | `int` | **Gerekli**  User ID |
| `userName` | `int` | **Gerekli**  Kullanıcı Adı |
| `userSurname` | `int` | **Gerekli** Kullanıcı Soyadı |
| `userEmail` | `string` | **Gerekli**  Kullanıcı email |
| `userPass` | `string` | **Gerekli**  Kullanıcı Parola |
| `userPhone` | `string` | **Gerekli** Kullanıcı Telefon |
| `userTc` | `datetime` | **Gerekli**  Kullanıcı TC |
| `userPlate` | `datetime` | **Gerekli**  Kullanıcı Plaka |
| `manager` | `int` | **Gerekli**  Manager ID |
| `userRole` | `datetime` | **Gerekli**  Kullanıcı Role |

```json
{
  "userId": 0,
  "userName": "string",
  "userSurname": "string",
  "userEmail": "string",
  "userPass": "string",
  "userPhone": "string",
  "userTc": "string",
  "userPlate": "string",
  "manager": 0,
  "userRole": "string"
}
```
## Ekran Görüntüleri

![bmsDiagram](https://user-images.githubusercontent.com/71569624/173257957-e5a1428d-61e0-41fb-8599-7aab6e21733e.PNG)
![BuildingMsEkran](https://user-images.githubusercontent.com/71569624/173257958-1cc772b5-8cee-4951-b2ee-8775f8e4010a.PNG)

  
