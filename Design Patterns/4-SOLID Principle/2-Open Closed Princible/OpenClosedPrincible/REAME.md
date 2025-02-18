# Open Closed Princible
SOLID prensiplerinin “O”su Open-Closed Prensibi yani Açık-Kapalı prensibi bir sınıfın veya modülün geliştirme için açık ancak değiştirme için kapalı olması gerektiğini söyler.Yani daha basit bir ifade ile bu prensip var olan kodun
değiştirilmeye kapalı ancak geliştirmeye açık olmasını ifade eder. Bu prenisibi buradaki kod yapaısyla acıklayacağım.

## Kod Yapısı ve OCP 
Aşağıdaki kod OCP prensibine aykırıdır. Cunku sistem yeni bir employee turu eklediğimizde aşağıdaki koda yeni bir if bloğu ekleyeceğiz. Yani bu kod değişime kapalı olması gerekirken acıktır.Yani mevcut yapıyı bozmadan kodu genişletemiyoruz.

![image](https://github.com/user-attachments/assets/7ab07437-2ba7-4eae-9d63-a3164b12aa84)

Aşağıdaki gibi employee için oncelikle interface olusturdum ve her bir employee turu için class olusturup bu interface i inherit ettim.Daha sonra Employee class da ortak method olusturdum.Yani suan yeni bir employee turu eklense
yeni bir employee turu için class olusturup interface i inherit etmek yetecek. Mevcut kod yapısı değişime kapalı oldu ve kod genişletilmeye açık oldu.

![image](https://github.com/user-attachments/assets/c0c89a55-b1d7-44c6-95c1-106b76b93bac)

Aşağıdaki test kodunu calısıtrıdım ve  outputu aldım.

![image](https://github.com/user-attachments/assets/0e460a49-64a4-40fa-9e9d-7ab82d0577ee)








