# Single Resposibility Princible

Bu prensip bir class ın sadece bir sorumluluğu olmalı esasına dayanmaktadır. Yani bir sınıf birden fazla entity nin sorumluluklarını da kapsamamalı. Hemen kod buradaki ornekle acıklayalım.

## Kod Yapısı

Aşağıdaki "NonSingleResponsiblePrincibleCompany" class ı bu prensibe aykırıdır.Cünkü bu sınıf hem kitap bilgililerini saklıyor hem kitap bilgisini fotmatlayıp veriyor hemde fiyatını hesaplıyor. Yani bu sınıfın birden fazla 
sorumlulugu var.

![image](https://github.com/user-attachments/assets/2d918640-a082-4e2c-967d-90cc4e614533)

Bu class ı asagıdaki gibi SRP prensibe uyacak sekilde uc farklı class a boldum.Artık her sınıfın kenine ait yalnızca bir tane sorumluluğu var.

![image](https://github.com/user-attachments/assets/6a182d94-7aa0-4cf7-83b8-91f7f7099504)

Aşağıdaki gibi kodu calıstırdım.

![image](https://github.com/user-attachments/assets/dbd1c16a-3966-4fd9-9e6f-32120b550d6c)

Cıktısı:

![image](https://github.com/user-attachments/assets/a779d518-75bf-480a-8330-ee097f70e3f3)






