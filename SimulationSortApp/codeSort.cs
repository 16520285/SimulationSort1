using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimulationSortApp
{
    class CodeSort
    {
        public static ListBox code;
        private static string[] Convert(string text)
        {
            string[] texts;
            texts = text.Split('\n');
            return texts;
        }
        public static void BubbleSort(bool asc)
        {
            string[] text=Convert(
@"Sắp tăng                
void BubbleSort(int a[], int N)
{
   int i,j;
   for(i = 0; i < N - 1; i++)
      for(j = N - 1; j > i; j--)
        if(a[j] < a[j - 1])
            Swap(a[j], a[j - 1]);
}");
            code.Items.Clear();
            foreach(string item in text)
            {
                code.Items.Add(item);
            }
            if (asc == false) 
            {
                code.Items[0] = "Sắp giảm";
                code.Items[6] = "       if(a[j] > a[j - 1])";
            }
        }
        public static void SelectionSort(bool asc)
        {
            string[] text = Convert(
@"Sắp tăng:
void SelecttionSort(int arr[], int N)
{
    int min, i, j;
    for (i=0; i < N-1; i++)
    {
        min = i;
        for (j=i+1; j <N; j++)
            if (a[j] < a[min])
                    min=j;
        Swap(a[min], a[i]);   
    } 
}");
            code.Items.Clear();
            foreach (string item in text)
            {
                code.Items.Add(item);
            }
            // nếu là giảm thì sửa lại
            if (!asc)
            {
                code.Items[0] = "Sắp giảm";
                code.Items[8] = "            if (a[j] > a[min])";
            }
        }
        public static void InsertionSort(bool asc)
        {
            string[] text = Convert(
@"Sắp tăng
                  
void InsertionSort(int a[], int N)
{
    int pos, i;
    int x;
    for(i = 1; i < N; i++)
    {
        x = a[i]; pos = i - 1;
        while((pos >= 0) && (x < a[pos]))
        {
            a[pos + 1] = a[pos];
            pos--;
        }
        a[pos + 1] = x;
    }
}");
            code.Items.Clear();
            foreach (string item in text)
            {
                code.Items.Add(item);
            }
            if (!asc)
            {
                code.Items[0] = "Sắp giảm";
                code.Items[9] = "        while((pos >= 0) && (x > a[pos]))";
            }
        }
        public static void BinaryInsertionSort(bool asc)
        {
            string[] text = Convert(
@"Sắp tăng
void BinaryInsertionSort(int a[], int N)
{
   int left, right, m, i , pos;
   int x;
   for(int i = 1; i < N ; i++)
   {
      x = a[i]; left = 0; right = i - 1;
      while(left <= right)
      {
         m = (left + right)/2;
         if(x < a[m]) right = m - 1;
         else left = m + 1;                    
      }
      for(pos = i - 1; pos >= left; pos--)
         a[pos+1] = a[pos];
      a[left] = x;
    }
}");
            code.Items.Clear();
            foreach (string item in text)
            {
                code.Items.Add(item);
            }
            if (!asc)
            {
                code.Items[0] = "Sắp giảm";
                code.Items[11] = "         if(x > a[m]) right = m - 1;";
            }
        }
        public static void InterchangeSort(bool asc)
        {
            string[] text = Convert(
@"Sắp tăng
void InterchangeSort( int a[], int N)
{
    int i, j;
    for(i = 0; i < N - 1; i++)
        for(j = i + 1; j < N; j++)
            if( a[j] < a[i] )
                Swap( a[i], a[j]);
}");
            code.Items.Clear();
            foreach (string item in text)
            {
                code.Items.Add(item);
            }
            if (!asc)
            {
                code.Items[0] = "Sắp giảm";
                code.Items[6] = "            if( a[j] > a[i] )";
            }

        }
        public static void ShakerSort(bool asc)
        {
          string[] text = Convert(
@"Sắp tăng
void ShakerSort(int a[], int N)
{
    int j, left, right, k;
    left = 0; right = N - 1, k = N - 1;
    while(left < right)
    {
    for(j = right; j > left; j--)
        if(a[j] < a[j - 1])
        {
            Swap(a[j], a[j - 1]);
            k = j;
        }
    left = k;
    for(j = left; j < right; j++)
        if(a[j + 1] < a[j])
        {
            Swap(a[j], a[j + 1]);
            k = j;
        }
    right = k;
    }
}");
            code.Items.Clear();
            foreach (string item in text)
            {
                code.Items.Add(item);
            }

            if (!asc)
            {
                code.Items[0] = "Sắp giảm";
                code.Items[8] = "        if(a[j] > a[j - 1])";
                code.Items[15] = "        if(a[j + 1] > a[j])";
            }

        }
        public static void HeapSort(bool asc)
        {
            string[] text = Convert(
@"Sắp tăng    
void HeapSort(int a[], int N)
{
    CreateHeap(a,N - 1);
    int r;
    r = N - 1;
    while(r >= 0)
    {
        Swap(a[0], a[r]);
        r--;
        if(r > 0 )
            Shift(a,0,r);
    }
}

void CreateHeap(int a[], int N)
{
    int l;
    l = N/2 - 1;
    while(l >= 0)
    {
        Shift(a,l,N - 1);
        l--;
    }
}

void Shift(int a[], int l, int r)
{
    int i = l;
    int j = 2*i + 1;
    while(j <= r)
    {
        if(j < r && a[j] < a[j+1]) 
            j++;
        if(a[i] < a[j])
        {
            Swap(a[i], a[j]);
            i = j; 
            j = 2*i + 1;
        }
        else return;
    }
}
");
            code.Items.Clear();
            foreach (string item in text)
            {
                code.Items.Add(item);
            }
            if (!asc)
            {
                code.Items[0] = "Sắp giảm";
                code.Items[32] = "        if(j < r && a[j] > a[j+1]) ";
                code.Items[34] = "        if(a[i] > a[j])";
            }

        }
        public static void QuickSort(bool asc)
        {
            string[] text = Convert(

@"Sắp tăng   
void QuickSort(int a[], int left, int right)
{
    int i, j, x;
    x = a[(left + night)/2];
    i = left, j = right;
    do
    {
        while(a[i] < x)
            i++;
        while(x < a[j])
            j--;
        if(i <= j)
        {
            Swap(a[i], a[j]);
            i++, j--;
        }            
    }while(i <= j);
    if(left < j)
        QuickSort(a, left, j);
    if(i < right)
        QuickSort(a, i, right);
}
");
            code.Items.Clear();
            foreach (string item in text)
            {
                code.Items.Add(item);
            }
            if (!asc)
            {
                code.Items[0] = "Sắp giảm";
                code.Items[8] = "        while(a[i] > x)";
                code.Items[10] = "        while(x > a[j])";
            }

        }
        public static void MergeSort(bool asc)
        {
            string[] text = Convert(
  @"Sắp tăng
int b[MAX], c[MAX], nb, nc;
int Min(int a, int b)
{
    if(a > b) return b;
    else return a;
}
void Distribute(int a[], int N, int &nb, int &nc, int k)
{
    int i, pa, pb, pc;
    pa = pb = pc = 0 ;
    while(pa < N)
    {
        for(i = 0; (pa < N) && (i < k); i++, pa++, pb++)
            b[pb] = a[pa];
        for(i = 0; (pa < N) && (i < k); i++, pa++, pc++)
            c[pc] = a[pa];
    }
    nb = pb; nc = pc;
}
void Merge(int a[], int nb, int nc, int k)
{
    int p, pb, pc, ib, ic, kb, kc;
    p = pb = pc = 0; ib = ic = 0;
    while((nb > 0) && (nc > 0))
    {
        kb = Min(k, nb); kc = Min(k, nc);
        if(c[pc + ic] < b[pb + ib] == false)
        {
            a[p++] = b[pb + ib]; ib++;
            if(ib == kb)
            {
                for(;ic < kc; ic++)
                    a[p++] = c[pc + ic];
                pb += kb; pc += kc; ib = ic = 0;
                nb -= kb; nc -= kc;
            }
        }
        else
        {
            a[p++] = c[pc + ic]; ic++;
            if(ic == kc)
            {
                for(;ib < kb; ib++)
                    a[p++] = b[pb + ib];
                pb += kb; pc += kc; ib = ib = 0;
                nb -= kb; nc -= kc;
            }
        }
    }
}
void MergeSort(int a[], int N)
{
        int k;
        for(k = 1; k < N; k*= 2)
        {
            Distribute(a, N, nb, nc, k);
            Merge(a, nb, nc, k);
        }
}");
            code.Items.Clear();
            foreach (string item in text)
            {
                code.Items.Add(item);
            }
            if (!asc)
            {
                code.Items[0] = "Sắp giảm";
                code.Items[27] = "        if(c[pc + ic] > b[pb + ib] == false)";
            }
        }
        public static void ShellSort(bool asc)
        {
            string[] text = Convert(
@"Sắp tăng
void ShellSort (int a[], int N)
{
    for (int gap = N / 2; gap > 0; gap /= 2)
    {
        for (int i = gap; i < N; i++)
        {
            for (int j = i; j >= gap && a[j] < a[j - gap]; j -= gap)
            {
                Swap(a[j], a[j - gap]);
            }
        } 
    }
}             
 ");
            code.Items.Clear();
            foreach (string item in text)
            {
                code.Items.Add(item);
            }
            if(!asc)
            {
                code.Items[0] = "Sắp giảm";
                code.Items[7] = "for (int j = i; j >= gap && a[j] > a[j - gap]; j -= gap)";
            }

        }
    }
}
