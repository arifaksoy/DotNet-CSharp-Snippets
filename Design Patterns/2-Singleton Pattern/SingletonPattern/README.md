# Singleton Desing Pattern
Bu design pattern creational kategorisine dahildir. Bu design patternın amacı bir class in sadece bir instance ı olusmasını sağlamaktır.Yani program calıstığında eğer bir class ın instance ı yoksa yeni bir instance olustur,eğer
varsa var olan instance ı kullan temeline dayanır. Aşağıda singleton uml diyagramı yer almaktadır.

![image](https://github.com/user-attachments/assets/0d410292-86d4-49bc-a74d-a137ff2d0297)

#### Üç Temel Aşama
Singleton üç ana aşamadan meydana gelir.

1. Private static class turunde bir state tanımla. 
2. Class ı private yap boylelikle new ile diğer sınıflardan obje oluştumayı engelle. 
3. Bir public static method la class daki state e eğer null ise class objesini ata null değil ise statede var olan class objesini dön.

## Code Base Açıklaması

Farklı şekillerde bu desing patternı uygulayabiliriz.
Aşağıdaki resimde temel singleton tasarımı goruyoruz. Yukarıdaki açıklamaya gore tasarımı uyguladık.

![image](https://github.com/user-attachments/assets/9753eca3-58ed-4cbe-ad78-bd8cbd92f427)

Bir diğeri ise thread safe yontemi ile tasarlanabilir. Bu multithread sistemlerde eğer başka bir thread instance ı olusturduysa bunu yeniden olusturmayı engllemek için boyle bir tasarım yapışır.Aşağıdaki kod parcasında lock thread
kilitlemesini sağlar. İkinci kez null kontrolu yapmmaızın nedeni eğer bir thread kilidi bıraktıysa bir sekilde yine null olup olmadığından emin olmak istiyoruz.

![image](https://github.com/user-attachments/assets/e325e742-972c-48c3-9fbf-bd9162554d25)

Bir üçüncü tasarlama şekli ise Lazy class ı kullanmaktır. Bu class yeni instance olusturulmasını ve thread safe i sağlar. En buyuk avantajı sade ve temiz kod yapısı sunmasıdır.

![image](https://github.com/user-attachments/assets/d62e5a8a-d540-4935-a10b-9565cbb2d5a5)

Aşağıdaki kodu çalıstırdım ve çıktısını aldım. İki kere instance olusturmaya calıstım ve tek bir instance olustu.Çünkü aynı hash code sahipler.

![image](https://github.com/user-attachments/assets/a2613dad-43af-48fd-8b10-207c39a5935d)

![image](https://github.com/user-attachments/assets/9832163d-1383-4adc-b03a-aaa46e85a218)









