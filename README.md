# Linked List Puzzle
- 16 parçalı puzzle oyunu, bir resmin 16 parçaya bölündüğü ve bu parçaların karışık şekilde kullanıcının sırayla birleştirmesi gerektiği bir oyundur. Bu oyun, bağlı liste veri yapısı kullanılarak oluşturulabilir.

- Oyunun amacı, kullanıcının verilen karışık parçaları doğru sıraya yerleştirmesidir. Oyuncu, her hamleyi yapmadan önce bir parçayı seçer ve bu parçayı oyundaki boş yere taşır. Parçaların sıraya konulmasıyla resim tamamlanır ve kullanıcı kazanır.

- Bağlı liste veri yapısı, her bir parçanın oyundaki konumunu ve komşularını (yukarıda, aşağıda, solda ve sağda) saklamak için kullanılabilir. Her bir düğüm, oyun tahtasındaki bir kareyi temsil eder ve her bir düğüm, komşu düğümlere işaret eden bağlantılar içerir.

- Bu oyunun başlatılması sırasında, ilk adım olarak resim 16 parçaya bölünür. Her bir parça bir düğüm oluşturur ve bu düğümler bir bağlı liste halinde depolanır. Her düğüm, oyun tahtasındaki bir kareyi temsil eder ve her bir düğüm, komşu düğümlere işaret eden bağlantılar içerir.

- Oyuncunun hamleleri, oyuncunun seçtiği parçanın bağlı listesi üzerinde yapılır. Örneğin, bir parçayı taşımak için, oyuncu seçilen parçanın düğümünü taşır ve komşularına işaret eden bağlantıları günceller. Bu işlem, bağlı listenin yeniden düzenlenmesi gerektiği için, düğümlerin yerlerini değiştirerek gerçekleştirilir.

- Ayrıca, her hamlede puanlama yapılmalıdır. Doğru hamleler 5 puan, yanlış hamleler -10 puan ile ödüllendirilir. Bu şekilde, oyuncunun yüksek puan almaya çalışması ve doğru hamleleri yapmaya teşvik edilmesi sağlanabilir.

## Oyun İle İlgili Görseller
- Giriş ekranı: Proje açıldığında bir isim girmeniz beklenmektedir. Daha sonra “start game” diyerek başlatılır.
![foto1](https://user-images.githubusercontent.com/56548687/230567331-8c9dba8d-cf4f-45d4-8257-8ea9804f5388.png)

- Oyun ekranı: Start game dedikten sonra açılan ekranda bir görsel yüklemek gerekiyor. Daha sonra “shuffle” diyerek karıştırıyoruz. Sağ tarafta girilen isim, hamle sayısı ve skor puanımız geliyor.
![önemli1](https://user-images.githubusercontent.com/57071570/230606452-6e2b552b-7473-4ed8-80e8-9e4787081b13.png)
![önemli 2](https://user-images.githubusercontent.com/57071570/230606529-047a2115-f257-42ce-b419-08118e8fd57d.png)

-Puzzle tamamlandıktan sonra karşınıza aşağıdaki ekran gelir. Burada isim, skor puanı ve hamle sayısı görülmektedir. İstenirse “Restart Game” diyerek tekrar oynanabilir. Ayrıca skor tablosu txt dosyası olarak da bilgisayarınıza aşağıdaki şekilde kayıt edilmektedir.
![foto4](https://user-images.githubusercontent.com/57071570/230606606-a3d28c6f-4c00-4e15-882c-0a22b8683740.png)



## Geliştirme Ortamı Hakkında![Uploading önemli 2.png…]()


- Video oyunları ve diğer interaktif 3B uygulamaların oluşturulmasını sağlayan popüler bir oyun motorudur. Unity'nin özellikleri arasında grafik motoru, fizik motoru, ses motoru, oyun nesneleri ve özellikleri, animasyon sistemleri, yazılım entegrasyonları ve birçok diğer araç bulunur. Geliştiriciler, oyunları veya uygulamaları aynı anda birden fazla platforma yayınlamak için tek bir kod tabanı kullanabilirler. Bu, geliştiricilerin uygulamalarının daha geniş bir kitleye ulaşmasını sağlar. Unity aynı zamanda kolay kullanımı ve öğrenilmesi için tasarlanmıştır. Kullanıcılar, basit bir sürükle ve bırak arabirimiyle, grafik sanatçıları, yazılım geliştiricileri ve diğer ekip üyeleri arasında işbirliğini kolaylaştıran bir araçlar yelpazesiyle çalışabilirler.

## Kodun yapısı aşağıdaki gibidir:

### Bağlı Liste Oluşturma

- Resim 16 parçaya bölünür ve her bir parça bir düğüm oluşturur.
- Düğümler, komşularına işaret eden bağlantıları içerir.
- Oyunun başlatılması

- Düğümler, bağlı listeye eklenir.
- Oyun tahtası ekrana yazdırılır.

### Kullanıcının hamleleri

- Taşınan parçanın yeni konumu, bağlı listesi üzerindeki düğümlerin yerlerinin değiştirilmesiyle güncellenir.
- Her hamlede puanlama yapılır ve doğru hamleler 5 puan, yanlış hamleler -10 puan ile ödüllendirilir.
- Kullanıcının kazanması durumu, resim tamamlanana kadar beklenir.
 
## Özellikler

- Hamle sayısı sayma.
- Uygun puan verme.
- Kullanıcı puanlarını sıralama.
- Fotoğrafı 16 parçaya ayırma.
- Her bir parçayı linked liste atama.

  
## Ekler

Herhangi bir ek bilgi buraya gelir

  
## Lisans

License

[![MIT License](https://img.shields.io/badge/License-MIT-green.svg)](https://choosealicense.com/licenses/mit/)
[![GPLv3 License](https://img.shields.io/badge/License-GPL%20v3-yellow.svg)](https://opensource.org/licenses/)


  
## Bilgisayarınızda Çalıştırın

Projeyi klonlayın

```bash
  git clone https://github.com/ofaruksevinc/LinkedListPuzzle.git
```

Proje dizinine gidin

```bash
  cd LinkedListPuzzle
```




  
