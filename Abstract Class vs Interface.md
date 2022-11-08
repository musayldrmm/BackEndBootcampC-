# BackEndBootcampWithCSharp

Abstract class; statik metotlar içerebilir.

Interface; override edilebilir statik metot içeremez.

Abstract class’da metotların gövdeleri (yani implementasyonları) olabilir.

Interface’de metotların ancak imzaları bulunabilir.

Abstract class; kurucu (constructor) ve yıkıcı (destructor) içerebilir.

Interface; kurucu (constructor) veya yıkıcı (destructor) içeremez. Ancak imzalarını içerebilir.

Abstract class’ın her access modifier’a (private, protected, public gibi) sahip metodu bulunabilir.

Interface’in metot imzaları ancak ‘public’ access modifier’ına sahip olabilir.

Abstract class -genel olarak- ancak bir sınıftan inheritance alabilir. Veya bir sınıf -genel olarak- ancak bir abstract sınıftan inheritance alabilir.

Interface birden fazla interface’den inheritance alabilir.

Abstract class, sınıfın neyden türediğini ifade edebilir (… is a …).

Interface, sınıfın hangi yeteneklere sahip olduğunu ifade edebilir (… can do …).

Ortak sınıf davranışı kazandırma için abstract class kullanılmalıdır.

Ortak yetenek metodu kazandırma için interface kullanılmalıdır.

Abstract class, nesnenin ne yapması gerektiğini belirlemek ile beraber nasıl yapması gerektiğini de belirleyebilir.

Interface, nesnenin ne yapması gerektiğini belirler ama nasıl yapması gerektiğini belirlemez.
