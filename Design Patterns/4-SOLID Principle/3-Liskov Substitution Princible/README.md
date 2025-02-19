# Liskov Substitution Princible
Bu prensip super class ile sub class ın uyumlu olması gerektiğini savunur. Aşağıdaki kurallarla bu ilkeyi açıklayalım.

### 1-Bir Sub class da Kullanılmayacak Olan Method u Override Etme

Diyelim ki cloud diye bir abstraction classımız olsun. Bunun abstract machineLearning ve translate diye iki tane methodu olsun. AWS,Google ve Azure bu class ı miras alsın.
AWS ve Google bu methodu kullanıyor cunku bunların machine learning ve translate ozellikleri var ama azure sadece machine learning kullanıyor cunku translate ozelliği yoktur.
Fakat abstract olduğu için tanımlamak zorundayım ve bu method hata fırlatıyor. Bu tasarım Liskov Substitution prensibine aykırıdır. Aiağıda kod yapısı yer almaktadır.

![image](https://github.com/user-attachments/assets/b989246f-3221-46c3-82fe-92fb6161f172)

Bunun yerine aşağıdaki tasarım Liskov Substitution princible a uygundur. Interfacelere methodları tasıyarak sorun cozulmustur.Boylelikle translate methodunu Azure class da
kullanmaya zorlamadık.

![image](https://github.com/user-attachments/assets/be2f0c78-dce7-43d6-a609-62c0db3ccfb2)

### 2-Dönüş Türleri
Bir diğer kural da sub class daki methoddaki parametreyi daha genel yapmaktır soyutlmaktır. Aşağıdaki kod ile açıklayalım.
Doğru Örnek: (Alt sınıf dönüş türünü daha spesifik hale getiriyor)

![image](https://github.com/user-attachments/assets/b20d401e-8664-4239-84ec-9206c9446621)

 Yanlış Örnek: (Dönüş türü daha genel hale getirildi)

 ![image](https://github.com/user-attachments/assets/0bc70356-b86d-4531-b66b-f476ae0619ae)

 ### 3-İstisnalar (Exception Handling)
 Bir alt sınıftaki metot, üst sınıfın beklemediği istisnaları atmamalıdır.

 ![image](https://github.com/user-attachments/assets/7557aabe-eec4-40ca-a9ef-3c780d16151a)

 TimeoutException, InvalidOperationException ile ilgili olduğundan, istemci kodu bunu bekleyebilir.

  Yanlış Örnek:
  ![image](https://github.com/user-attachments/assets/a0a49e52-38aa-4d0f-83dd-150d07740f31)

   UnstableDatabase, tamamen alakasız bir StackOverflowException fırlatıyor. İstemci kodu bu hatayı beklemiyorsa sistem çökebilir.

### 4-Ön Koşulları Güçlendirmemek (Preconditions)
Temel sınıfın metodu int türünde herhangi bir değer kabul edebilirken, alt sınıf yalnızca pozitif sayıları kabul etmeye çalışırsa LSP ihlal edilir.

Yanlış Kullanım (LSP'yi İhlal Eden Kod)

![image](https://github.com/user-attachments/assets/36cce26a-64eb-408e-832d-15fb83c4180a)

Bu durumda Calculator negatif sayılarla çalışıyordu, ancak SafeCalculator bunu kısıtladı. Bu, istemci kodunun hata vermesine neden olur.

 Doğru Kullanım :Ön koşulu güçlendirmek yerine, temel sınıfın varsayılan davranışını koruyarak genişletmeliyiz:

 ![image](https://github.com/user-attachments/assets/c18cb7b5-df73-4dcb-ac5c-333d30266145)

### 5-Son Koşulları Zayıflatmamak (Postconditions)

 Bir metodun belirli bir davranış sergilemesi beklenirken, alt sınıfta bu davranış değiştirildiğinde LSP ihlal edilir.

 Yanlış Kullanım (LSP'yi İhlal Eden Kod)

 ![image](https://github.com/user-attachments/assets/b84cc374-bffc-444b-9701-aa9e1bd8e2b2)

 Burada istemci kodu, Close() metodunun bağlantıyı kapatacağını bekler, ancak PersistentDatabaseConnection bu beklentiyi bozar.

 Doğru Kullanım:Alt sınıfta mevcut davranış korunmalı veya genişletilmelidir.

 ![image](https://github.com/user-attachments/assets/cc371c9e-23e8-4f49-8931-20955a24c299)

 ### 6- Değişmezleri (Invariants) Koruma
 Bir alt sınıfın metodu, parametre olarak temel sınıftan daha spesifik bir tür kullanırsa istemci kodu bozulabilir.

 Yanlış Kullanım (LSP'yi İhlal Eden Kod)

 ![image](https://github.com/user-attachments/assets/37f11c52-53eb-42a0-9b28-a2b7a7de24af)

 Burada Feeder sınıfı herhangi bir kedi alabilirken, BengalFeeder yalnızca BengalCat kabul ederek istemci kodunu kırar.

 Doğru Kullanım :Alt sınıf, parametre türünü daha spesifik hale getirmemelidir, ancak daha genel hale getirebilir

![image](https://github.com/user-attachments/assets/47102458-75e9-444e-9416-660337bd30e3)

Burada UniversalFeeder, yalnızca kediler değil, tüm hayvanları kabul ederek LSP'yi korur.






