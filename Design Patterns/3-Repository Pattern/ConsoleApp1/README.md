# Repository Design Pattern

Bu patern database crud işlemlerini businees logic işlemlerinden ayırmak için kullanılan bir patterndır. Aynı modelin aynı crud işlemini servicelerde tekrarlamayı sağlar.Daha duzenli okunaklı bir kod yapısı sağlar.
![image](https://github.com/user-attachments/assets/8d8ab3b0-4a8b-48ee-8001-d670b849479d)

## Code Yapısı

1- Aşağıdaki repository base class ını olusturdum.

![image](https://github.com/user-attachments/assets/c63d2ae8-bd1e-4fbb-9e34-cd3506be41df)

2- Repository interface class ı asağıdaki gibi oluşturdum.

![image](https://github.com/user-attachments/assets/35f5c564-66ca-4964-bf2b-12cdddafae80)

3- Aşağıdaki gibi yukarıda olusturduğum base ve interface classları repository classlara inherit ettim. Methodları tanımladım.

personnel
![image](https://github.com/user-attachments/assets/3f4af23d-3781-4ff4-970a-0b276e984655)

company
![image](https://github.com/user-attachments/assets/3e72c3b5-a904-4289-9da6-104a8a5e9c1a)

4- Aşağıda personnel repository i personnel serviceden kullanmayı gosterdim.

![image](https://github.com/user-attachments/assets/c821e12e-35e3-49eb-93d4-2b97f13c6161)

