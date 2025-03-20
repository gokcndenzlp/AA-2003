using System;

class DynamicArray
{
    private int[] _array;
    private int _count;

    public DynamicArray(int initialSize = 4)
    {
        _array = new int[initialSize];
        _count = 0;
    }

    // Eleman ekleme (Resize kullanarak genişleme)
    public void Add(int value)
    {
        if (_count == _array.Length)
        {
            Array.Resize(ref _array, _array.Length * 2); // .NET Resize fonksiyonu
        }
        _array[_count] = value;
        _count++;
    }

    // Belirtilen indeksteki elemanı okuma
    public int Read(int index)
    {
        if (index < 0 || index >= _count)
            throw new IndexOutOfRangeException("Geçersiz indeks!");

        return _array[index];
    }

    // Belirtilen indeksteki elemanı güncelleme
    public void Update(int index, int value)
    {
        if (index < 0 || index >= _count)
            throw new IndexOutOfRangeException("Geçersiz indeks!");

        _array[index] = value;
    }

    // Belirtilen değerin dizideki indeksini bulma
    public int IndexOf(int value)
    {
        return Array.IndexOf(_array, value, 0, _count); // .NET IndexOf kullanımı
    }

    // Belirtilen değeri silme (varsa)
    public void Delete(int value)
    {
        int index = IndexOf(value);
        if (index == -1)
        {
            Console.WriteLine("Silinecek eleman bulunamadı!");
            return;
        }

        for (int i = index; i < _count - 1; i++)
        {
            _array[i] = _array[i + 1];
        }

        _count--;
    }

    // Mevcut diziyi yazdırma
    public void Print()
    {
        Console.Write("[ ");
        for (int i = 0; i < _count; i++)
        {
            Console.Write(_array[i] + " ");
        }
        Console.WriteLine("]");
    }

    // Toplam kaç eleman var?
    public int Count()
    {
        return _count;
    }
}

// Kullanım Örneği
class Program
{
    static void Main()
    {
        DynamicArray arr = new DynamicArray();

        // Eleman ekleme (Create)
        arr.Add(10);
        arr.Add(20);
        arr.Add(30);
        arr.Add(40);
        arr.Add(50);  // Resize olacak burada
        arr.Print();

        // Eleman okuma (Read)
        Console.WriteLine("2. indeksteki eleman: " + arr.Read(2));

        // Eleman güncelleme (Update)
        arr.Update(1, 25);
        arr.Print();

        // Eleman arama (IndexOf)
        int index = arr.IndexOf(30);
        Console.WriteLine("30 değeri dizide " + (index != -1 ? index.ToString() : "bulunamadı"));

        // Eleman silme (Delete)
        arr.Delete(30);
        arr.Print();
    }
}

