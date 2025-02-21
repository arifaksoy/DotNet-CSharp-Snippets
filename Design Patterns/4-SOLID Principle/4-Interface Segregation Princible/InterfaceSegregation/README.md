# Interface Segregation Princible

Bu prensip interfaceler ile classların kullanmayacağı methodları implement etmesini engellemeye dayalı bir prensiptir. Yani bir interface de 4 tane method tanımlanmıs ve bu interface i 2 tane class inherit etmiş diyelim. 
Bu classlardan biri bu methodların hepsini kullanıyor ama diğer class sadece iki tanesini kullanıyor. Fakat Interface den dolayı bu iki methodu implement ediyor ama bu methodların içi bos kalıyor. Eğer bu class ı kullanan bir developer
o iki methodu bu class için kullanılıyor sanabilir ve bazı hatalara neden olabilir. İşte bu prensib boyle şişmiş interfaceleri daha kucuk interfacelere bolerek bu sorunu ortadan kadlırmayı oneriyor.
Aşağıda kod uzerinden bu prensibi anlatacağım.

## Code Yapısı ve Interface Segregation Prensibi

Aşağıdaki gibi CloudProvider interface i olusturdum ve methodlarını tanımladım.

![image](https://github.com/user-attachments/assets/f500a668-6e1f-4f61-81bf-4d1119362172)

Amozon classımı asağıdaki gibi tanımladım ve CloudProvider ı inherit ettim. Bu amozon class tum methoları kullanıyor.

![image](https://github.com/user-attachments/assets/51b12b24-9f0f-4446-b310-45a2e4b1cfc4)

DropBox class ını da aşağıdaki gibi tanımladım ve yine burada da CloudProvider ı inherit ettim. Ancak burada bazı methodları bu class desteklemiyor ve geriye bir hata fırlatıyor.

![image](https://github.com/user-attachments/assets/ef25d770-af6d-415d-9a1a-0e52f0d1c1e7)

İşte Interface Segregation prencible bunun yanlış bir tasarım olduğunu savunuyor ve bu şişmiş interface i daha kucuk interfacelere ayırmamızı istiyor. Aşağıdaki gibi methodları 3 interface e ayırdım.

![image](https://github.com/user-attachments/assets/52752448-eecd-4cb5-82fd-98edc1a036fa)

Daha sonra class ları asağıdaki gibi tanımladım ve gerekli interfaceleri inherit ettim. Boylelike Dropbox classında gereksiz methodları implement etmek zorunda kalmadım.

![image](https://github.com/user-attachments/assets/54757132-fa2b-4b41-b48c-a1079f18284b)

![image](https://github.com/user-attachments/assets/7fa1a320-b6f5-4c6a-9f51-f9d92248bd69)


