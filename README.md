# LinkedListPuzzle
16 parçalı puzzle oyunu, bir resmin 16 parçaya bölündüğü ve bu parçaların karışık şekilde kullanıcının sırayla birleştirmesi gerektiği bir oyundur. Bu oyun, bağlı liste veri yapısı kullanılarak oluşturulabilir.

Oyunun amacı, kullanıcının verilen karışık parçaları doğru sıraya yerleştirmesidir. Oyuncu, her hamleyi yapmadan önce bir parçayı seçer ve bu parçayı oyundaki boş yere taşır. Parçaların sıraya konulmasıyla resim tamamlanır ve kullanıcı kazanır.

Bağlı liste veri yapısı, her bir parçanın oyundaki konumunu ve komşularını (yukarıda, aşağıda, solda ve sağda) saklamak için kullanılabilir. Her bir düğüm, oyun tahtasındaki bir kareyi temsil eder ve her bir düğüm, komşu düğümlere işaret eden bağlantılar içerir.

Bu oyunun başlatılması sırasında, ilk adım olarak resim 16 parçaya bölünür. Her bir parça bir düğüm oluşturur ve bu düğümler bir bağlı liste halinde depolanır. Her düğüm, oyun tahtasındaki bir kareyi temsil eder ve her bir düğüm, komşu düğümlere işaret eden bağlantılar içerir.

Oyuncunun hamleleri, oyuncunun seçtiği parçanın bağlı listesi üzerinde yapılır. Örneğin, bir parçayı taşımak için, oyuncu seçilen parçanın düğümünü taşır ve komşularına işaret eden bağlantıları günceller. Bu işlem, bağlı listenin yeniden düzenlenmesi gerektiği için, düğümlerin yerlerini değiştirerek gerçekleştirilir.

Ayrıca, her hamlede puanlama yapılmalıdır. Doğru hamleler 5 puan, yanlış hamleler -10 puan ile ödüllendirilir. Bu şekilde, oyuncunun yüksek puan almaya çalışması ve doğru hamleleri yapmaya teşvik edilmesi sağlanabilir.

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



  
