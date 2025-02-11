# Factory Method

Factory method nesne oluşturmayı merkezi bir methodda(factory method) toplamayı amaçlayan ve istemcilerin oluşturacak alt sınıfların constractorlarına doğrudan erişmesini
engelleyen bir design patterndır.
Aşağıda factory methoddun bir uml diyagramı verilmiştir.


![image](https://github.com/user-attachments/assets/675667e8-61ab-494e-967c-77dbd78a1e4d)

## Code Base Açıklama
Bu küçük projede factory design patternı uyguladım. Şimdi kod üzerinden açıklamaya devam edeceğim. 

Aşağıdaki resimde payment sınıflarımı oluşturdum ve bunların ortak davranışlarını belirliyen interface i inherit ettim.

![image](https://github.com/user-attachments/assets/02925643-ecc0-46eb-a750-1b0bb6faac55)

Factory methodumun olduğu factory sınıfımı aşağıdaki gibi oluşturdum. Görüldüğü gibi kullanılacak nesnenin türü startPayment() methodunda belirleniyor. Bu methodda 
CreatePayment() methodu cağırılarak alt sınıftan nesne türü alınıyor.

![image](https://github.com/user-attachments/assets/ef26a537-4a43-4979-8915-64002fadd2b0)

Aşağıdaki istemcilerin ulaştığı sınıflar tanımlandı ve abstract class olan factory class ı inherit edildi ve CreatePayment methodu override edildi. İşte buradan nesnenin
türü gonderiliyor.

![image](https://github.com/user-attachments/assets/fc04318b-db8c-4100-9257-3640692a4532)

Uygulama da aşağıdaki code parçasıyla run ediliyor.

![image](https://github.com/user-attachments/assets/f56b1255-0d7e-4f7d-bd3b-c816018f7c25)

Çıktı da aşağıdaki gibidir.

![image](https://github.com/user-attachments/assets/94788560-ad83-4aa4-8d95-2dc69556d041)








