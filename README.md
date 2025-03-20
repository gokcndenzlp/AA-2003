# AA-2003
### **Array Bazlı Veri Yapılarında CRUD İşlemleri ve Karmaşıklıkları**
Array (dizi) tabanlı veri yapıları, sabit boyutlu veya dinamik olarak genişleyebilen veri koleksiyonlarıdır. CRUD işlemleri (Create, Read, Update, Delete) açısından farklı zaman karmaşıklıklarına sahiptirler.

## **1. CRUD İşlemlerinin Karmaşıklıkları**
# Create (Oluşturma)

Statik Diziler: Sabit boyutlu bir dizi oluşturma işlemi O(1) sürede gerçekleşir.
Dinamik Diziler: Dinamik diziler (örn. Python list, Java ArrayList) kapasiteyi aşarsa, yeni bir dizi oluşturulup eski veriler buraya taşınır. Bu, ortalama O(1) olsa da kapasite dolduğunda O(n) sürebilir.

# Read (Okuma)

Dizilerde belirli bir indeksteki elemana doğrudan erişim O(1) zaman alır.

# Update (Güncelleme)

Belirli bir indeksteki elemanı değiştirme de doğrudan erişimle mümkün olduğu için O(1) sürede gerçekleşir.

# Delete (Silme)

Orta veya baştan silme: Elemanın silinmesi sonrası kalan elemanların kaydırılması gerektiğinden O(n) sürede gerçekleşir.
Sondan silme: Son elemanın silinmesi O(1) sürede olur.

## **2. Amortized Cost ve Dinamik Dizilerde Karmaşıklık**
Dinamik diziler, iç kapasiteleri dolduğunda daha büyük bir diziye genişleyerek çalışır. Bu genişleme O(n) sürede gerçekleşse de, genişleme işlemi seyrek yapıldığından amortized cost O(1) olur.

# Örneğin:

Eğer bir dizi N elemanlı ve kapasitesi dolduğunda 2N boyutunda yeni bir dizi oluşturuluyorsa, tüm elemanlar kopyalanır.Ancak, genişleme her eklemede gerçekleşmediği için ortalama ekleme süresi 
O(1) kabul edilir.

# Özetle:
Statik diziler hızlı okuma ve güncelleme sunarken ekleme ve silmede pahalı olabilir.
Dinamik diziler ekleme ve silmede amortized O(1) performans sağlayabilir ancak genişleme anında O(n) maliyet getirir.






