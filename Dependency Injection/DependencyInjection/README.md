# Dependency Injection

Bir class da nesneyi olusturmak yerine dışarıdan enjekte edilmesini sağlayan bir design patterndır. Orneğin bir "Service" diye classımız olsun. Bu classdan bir 
controllerda nesne uretelim diyelim. Bunu "new" key ile yapıyoruz. => "var service = new Service();"
Bu code memory de stack-Heap yapısıyla calısır. "new Service();" dediğimde hafızada bu nesne için bir yer ayrılıyor. Aynı controllerda veya baska yerlerde 
yine new ile bu classdan nesne olusturdum diyelim hafızada yine yeni bir yer ayrılıyor. Boyle yuzlerce class da yeni yeni objeler uretirsem hem bellek maliyeti hemde
code bakım zorluğu ortaya cıkar. Code bakım zorluğunu açmam gerekirse; diyelim ki class da bir değişiklik yaptık bu değişikliği class dan uretilen nesnelerin olduğu 
heryerde uygulamam gerekiyor. 

İşte bu maliyetleri DI ile aşıyorum. Bu design pattern bağımlılıkları en aza indiriyor. Bir class ın interface i olusturuyoruz ve  bu interface ile objeyi başka bir class a
enjekte ediyoruz. Ayrıca nesneden kac tane ve ne zaman ureteceğimizi de karar verebiliyoruz. Bunları Life cycle dediğimiz yaşam donguleriyle yapıyoruz.
Uc tane yasam dongusu vardır.

1. Singleton : Uygulama ömrü boyunca tek nesne
2. Scoped :HTTP isteği boyunca aynı nesne
3. Transient :Kısa ömürlü, her talepte yeni nesne

   Yukarıda anlatıklarımı bu basit API uygulamasında uyguladım ve sonuclarını asağıda paylastım.

   İlk once serviceler classlarımı ve interfacelerimi tanımladım. Her class bir guid uretiyor.

   ![image](https://github.com/user-attachments/assets/d67feb42-2daa-4442-b625-84fa0bad326a)
     
   ![image](https://github.com/user-attachments/assets/e506dcb2-30c6-400c-bd1a-21c15dcae2d7)

   Daha sonra program.cs dosyasında LifeCycle ları tanımladım.

   ![image](https://github.com/user-attachments/assets/bfd115e9-2c18-4544-85aa-5b61ae4f6bf5)

   Daha sonra controller da bu service classları enjekte ettim ve her biri için bir endpoint olusturdum.

   ![image](https://github.com/user-attachments/assets/a35dc4ae-9d0c-4185-91cc-7a412cce90d1)

   Şimdi tek tek life sycleları test ediyorum.

   #### Singleton Test

   Tanım suydu => "Uygulama ömrü boyunca tek nesne".
   Aşağıdaki resimde bir http isteği attım ve olusan guid lerin aynı olduğunu gordum. Her nesne isteğinde aynı nesne gonderildi.Fakat tanımda uygulama omru boyunca tek nesne diyor her http istediğnde demiyor.
   Yani uygulama calıstığı surece bir nesne diyor.

  ![image](https://github.com/user-attachments/assets/37b48209-e094-42cf-b90a-1b795d3aca28)

  Uygulamayı durdurmadan bir htpp isteği daha atıyorum ve aşağıdaki gibi nesnenin değişmediğini goruyorum.

  ![image](https://github.com/user-attachments/assets/c2b09e8c-9f0c-4f02-849a-fb91f48c1612)

  Eğer uygulamayı durdurup yeniden calıstırısam ve http isteği yaparsam Guid in değiştiğini yani nesne nin değiştiğini goruyorum. Yani uygulama calsıtığı surece tek bir nesne uretildiğimi goruyorum.
  Singleton tanımı yerine geldi.

  ![image](https://github.com/user-attachments/assets/f4d5633b-42ca-43ca-8c19-b947f1553f78)

  #### Scoped Test

   Tanım suydu => "HTTP isteği boyunca aynı nesne".

  Aşağıdaki resimde bir hettp isteiğinde iki tane nesne isteği attım ve sonuc aşağıda gosterilmiştir. Bir http isteğinde iki nesne isteğine de aynı nesne gonderildi. 

  ![image](https://github.com/user-attachments/assets/7b1e2e4f-3ebd-4ee2-8fd6-32ca83f7746d)

  Bunun singleton dan farkı uygulamayı durdurmadan yeni bir http isteğinde yeni bir nesnenin uretilmesidir. Yeni http isteği attım ve sonucalar aşağıdadır.

  ![image](https://github.com/user-attachments/assets/ae44c141-293a-4d78-99ce-06370cc43621)

  #### Transient Test

    Tanım suydu => "Kısa ömürlü, her talepte yeni nesne".

  Aşağıda bir http isteğinde iki nesne isteğinde iki farklı Guid yani nesne donmustur. Yani singltondan ve scoped farkı bir http isteğinde her talepte bir nesne uretilmesidir.

  ![image](https://github.com/user-attachments/assets/d5c766b6-1c59-4aa0-ba6f-a08224380ca0)



  



   

