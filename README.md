# ToDo Uygulaması

Bu, basit bir TODO uygulamasıdır. Uygulama, kartlar ve durumları aracılığıyla görevlerinizi yönetmenize yardımcı olur.

## Özellikler

- Kart ekleme: Yeni kartlar oluşturarak görevlerinizi ekleyebilirsiniz.
- Kart güncelleme: Varolan kartları düzenleyebilirsiniz.
- Kart taşıma: Kartları farklı durumlar arasında taşıyabilirsiniz.
- Kart silme: İstenmeyen kartları silebilirsiniz.
- Board durumu listeleme: Mevcut kartları durumlarına göre listeleme.


## Kod Nasıl Yazıldı?

Bu projede, C# dilini ve Visual Studio Code geliştirme ortamını kullandık. İşte adım adım projenin gelişimi:

1. `KartBuyuklugu` adında bir enum oluşturdum ve kart büyüklüklerini tanımladım.
2. `Kart` sınıfını tanımladım ve kartın özelliklerini (başlık, içerik, atanan kişi, büyüklük, durum) oluşturdum.
3. `Program` sınıfını oluşturdum ve kartları ve takım üyelerini içeren listeleri tanımladım.
4. `Main` metodunu oluşturdum ve işlevleri gerçekleştiren bir switch-case yapısı ekledim.
5. İşlevlerin adımlarını takip ederek kart ekleme, kart güncelleme, kart taşıma, kart silme ve board durumu listeleme işlevlerini tanımladım.
