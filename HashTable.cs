using System;

namespace dev6a
{
    public class HashTable<K, V>
    {
       public Entry<K, V>[] Slots { get; set; }
        // aantal entries van de table
        public int Entries { get; set; }
        // grootte van de table
        public int Size { get; set; }

        public HashTable(int size)
        {
            Slots = new Entry<K, V>[size];
            Size = size;
        }

        public void Put(K key, V value)
        {
            Entry<K, V> NewEntry = new Entry<K, V>(key, value);
            int Hashcode = NewEntry.HashCode;
            int initialSlot = Hashcode % Size;


            if (Slots[initialSlot] == null)
            {
                Slots[initialSlot] = NewEntry;
                Entries++;
                 Console.WriteLine("added" + Hashcode + "immediate");
            }
             else
             {
                    if (Slots[initialSlot].Key.Equals(key)){
                        throw new ArgumentException("Key already exists");
                    }
             
            else
            {
                var pot = initialSlot + 1;
                while (Slots[pot] != null){
                    pot ++;
                    if(pot >= Size)pot = 0;
                    if(pot == initialSlot)return;
                }
                Console.WriteLine("added" + Hashcode);
                Slots[pot] = NewEntry;
                // int i = 1;
                // while (Slots[initialSlot + i] != null)
                // {
                //     i++;
                // }

                // Slots[initialSlot + i] = NewEntry;
                // Entries++;

            }
            CheckLoadFactor();
             }  
        }
        
        public V Get(int GivenKey)
        {
            int KeySlot  = GivenKey.GetHashCode() % Size;
            if(Slots[KeySlot] == null){ throw new Exception("no value with that hashcode");}
                     
           if(Slots[KeySlot].Key.Equals(GivenKey)){
               return Slots[KeySlot].Value;
           }

           
               for(int i = 1; i< Size; i ++){

                int NextKey =KeySlot + i;
                    if(NextKey > Size)
                    {
                        NextKey = i - 1;
                          Console.WriteLine("greater than size");
                    }
                     if(Slots[NextKey] == null)
                    {
                         Console.WriteLine("broke");
                         break;
                        
                    }

                    if(Slots[NextKey].Key.Equals(GivenKey))
                    {
                          Console.WriteLine("returns");
                        return Slots[NextKey].Value;
                    }
               }
           
           throw new Exception("key does not exists");
           
           
        }

        private void CheckLoadFactor()
        {
            float loadFactor = (float) Entries / Size;
            if (loadFactor > (2.0 / 3.0))
            {
                Resize();
            }
        }

        private void Resize()
        {
            Entry<K, V>[] newSlots = new Entry<K, V>[Size * 2];
            foreach (Entry<K, V> entry in Slots)
            {
                if (entry == null) continue;
                int newIndex = entry.HashCode % (Size * 2);

                // Also linear probing when resizing ?
                if (newSlots[newIndex] == null)
                {
                    newSlots[newIndex] = entry;
                }
                else
                {
                    for (int i = 1; i < (Size * 2); i++)
                    {
                        int probedSlot = newIndex + i;
                        if (probedSlot > Size * 2)
                        {
                            probedSlot = i - 1;
                        }

                        if (newSlots[probedSlot] != null) continue;
                        newSlots[probedSlot] = entry;
                        break;
                    }
                }
            }

            Size = Size * 2;
            Slots = newSlots;
        }
    }
    }

    public class Entry<K, V>
    {
        public K Key { get; set; }
        public V Value { get; set; }
        public int HashCode { get; set; }
        
        public Entry(K key, V value)
        {
            Key = key;
            Value = value;
            HashCode = key.GetHashCode();
        }
    }
