# Linked List Puzzle
16 parçalı puzzle oyunu, bir resmin 16 parçaya bölündüğü ve bu parçaların karışık şekilde kullanıcının sırayla birleştirmesi gerektiği bir oyundur. Bu oyun, bağlı liste veri yapısı kullanılarak oluşturulabilir.

Oyunun amacı, kullanıcının verilen karışık parçaları doğru sıraya yerleştirmesidir. Oyuncu, her hamleyi yapmadan önce bir parçayı seçer ve bu parçayı oyundaki boş yere taşır. Parçaların sıraya konulmasıyla resim tamamlanır ve kullanıcı kazanır.

Bağlı liste veri yapısı, her bir parçanın oyundaki konumunu ve komşularını (yukarıda, aşağıda, solda ve sağda) saklamak için kullanılabilir. Her bir düğüm, oyun tahtasındaki bir kareyi temsil eder ve her bir düğüm, komşu düğümlere işaret eden bağlantılar içerir.

Bu oyunun başlatılması sırasında, ilk adım olarak resim 16 parçaya bölünür. Her bir parça bir düğüm oluşturur ve bu düğümler bir bağlı liste halinde depolanır. Her düğüm, oyun tahtasındaki bir kareyi temsil eder ve her bir düğüm, komşu düğümlere işaret eden bağlantılar içerir.

Oyuncunun hamleleri, oyuncunun seçtiği parçanın bağlı listesi üzerinde yapılır. Örneğin, bir parçayı taşımak için, oyuncu seçilen parçanın düğümünü taşır ve komşularına işaret eden bağlantıları günceller. Bu işlem, bağlı listenin yeniden düzenlenmesi gerektiği için, düğümlerin yerlerini değiştirerek gerçekleştirilir.

Ayrıca, her hamlede puanlama yapılmalıdır. Doğru hamleler 5 puan, yanlış hamleler -10 puan ile ödüllendirilir. Bu şekilde, oyuncunun yüksek puan almaya çalışması ve doğru hamleleri yapmaya teşvik edilmesi sağlanabilir.

## Oyun İle İlgili Görseller
Görsel 1
![foto1](https://user-images.githubusercontent.com/56548687/230567331-8c9dba8d-cf4f-45d4-8257-8ea9804f5388.png)

## Geliştirme Ortamı Hakkında

Video oyunları ve diğer interaktif 3B uygulamaların oluşturulmasını sağlayan popüler bir oyun motorudur. Unity'nin özellikleri arasında grafik motoru, fizik motoru, ses motoru, oyun nesneleri ve özellikleri, animasyon sistemleri, yazılım entegrasyonları ve birçok diğer araç bulunur. Geliştiriciler, oyunları veya uygulamaları aynı anda birden fazla platforma yayınlamak için tek bir kod tabanı kullanabilirler. Bu, geliştiricilerin uygulamalarının daha geniş bir kitleye ulaşmasını sağlar. Unity aynı zamanda kolay kullanımı ve öğrenilmesi için tasarlanmıştır. Kullanıcılar, basit bir sürükle ve bırak arabirimiyle, grafik sanatçıları, yazılım geliştiricileri ve diğer ekip üyeleri arasında işbirliğini kolaylaştıran bir araçlar yelpazesiyle çalışabilirler.

## Kodun yapısı aşağıdaki gibidir:

    #Bağlı liste oluşturma

Resim 16 parçaya bölünür ve her bir parça bir düğüm oluşturur.
Düğümler, komşularına işaret eden bağlantıları içerir.
Oyunun başlatılması

Düğümler, bağlı listeye eklenir.
Oyun tahtası ekrana yazdırılır.

    #Kullanıcının hamleleri

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
  git clone https://link-to-project
```

Proje dizinine gidin

```bash
  cd my-project
```

Gerekli paketleri yükleyin 



  
