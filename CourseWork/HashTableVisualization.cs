namespace CourseWork
{
    public class HashTableVisualization
    {
        private readonly int? hashTableBucketWidth = 25;
        private readonly int? hashTableBucketHeight = 25;
        private readonly int? hashTableItemWidth = 50;
        private readonly int? hashTableItemHeight = 25;

        public void DrawHashTableBucket(Graphics g, int x, int y, int bucketNumber)
        {
            Pen pen = new(Color.Black);
            Brush brush = new SolidBrush(Color.Gray);
            if (hashTableBucketWidth.HasValue && hashTableBucketHeight.HasValue)
            {
                Rectangle rectangleBucket = new Rectangle(x, y, hashTableBucketWidth.Value, hashTableBucketHeight.Value);
                g.DrawRectangle(pen, rectangleBucket);
                // Вычисляем координаты, чтобы разместить текст (цифру) в центре прямоугольника
                float textX = x + (hashTableBucketWidth.Value - g.MeasureString(bucketNumber.ToString(), SystemFonts.DefaultFont).Width) / 2;
                float textY = y + (hashTableBucketHeight.Value - g.MeasureString(bucketNumber.ToString(), SystemFonts.DefaultFont).Height) / 2;

                // Рисуем текст (цифру) в центре прямоугольника
                g.FillRectangle(brush, rectangleBucket);
                g.DrawString(bucketNumber.ToString(), SystemFonts.DefaultFont, Brushes.Black, textX, textY);
            }
        }

        public void DrawHashTableItem(Graphics g, int x, int y, HashItem item, bool isFound)
        {
            Pen pen = new(Color.Black);
            Brush brush = new SolidBrush(isFound ? Color.Green : Color.White);
            if (hashTableItemWidth.HasValue && hashTableItemHeight.HasValue)
            {
                Rectangle rectangleItem = new Rectangle(x, y, hashTableItemWidth.Value, hashTableItemHeight.Value);
                g.DrawRectangle(pen, rectangleItem);
                g.FillRectangle(brush, rectangleItem);

                // Вычисляем координаты для размещения текста key в левой части прямоугольника
                float keyTextX = x + 5; // Небольшой отступ слева
                float keyTextY = y + (hashTableItemHeight.Value - g.MeasureString(item.Key.ToString(), SystemFonts.DefaultFont).Height) / 2;

                // Рисуем текст key в левой части прямоугольника
                g.DrawString(item.Key.ToString(), SystemFonts.DefaultFont, Brushes.Black, keyTextX, keyTextY);

                // Вычисляем координаты для размещения текста value в правой части прямоугольника
                float valueTextX = x + hashTableItemWidth.Value - g.MeasureString(item.Value.ToString(), SystemFonts.DefaultFont).Width - 5; // Небольшой отступ справа
                float valueTextY = y + (hashTableItemHeight.Value - g.MeasureString(item.Value.ToString(), SystemFonts.DefaultFont).Height) / 2;

                // Рисуем текст value в правой части прямоугольника
                g.DrawString(item.Value.ToString(), SystemFonts.DefaultFont, Brushes.Black, valueTextX, valueTextY);
            }
        }

        public void DrawHashTable(Graphics g, HashTableCondition condition)
        {
            Pen pen = new Pen(Color.Black);
            int startX = 15; // Начальная координата x для первой ячейки хэш-таблицы
            int startY = 15; // Начальная координата y для первой ячейки хэш-таблицы
            int spacingX = 60; // Расстояние между ячейками по горизонтали
            int spacingY = 40; // Расстояние между ячейками по вертикали

            // Визуализация ячеек хэш-таблицы
            for (int i = 0; i < condition.hashTablesize; i++)
            {
                DrawHashTableBucket(g, startX, startY + i * spacingY, i); // Отрисовка каждой ячейки хэш-таблицы
                int itemCount = 0;
                if (condition._hashTable[i] == null)
                {
                    continue;
                }

                int selectedItemIndex = -1; // Индекс найденного элемента
                int currentIndex = 0; // Текущий индекс элемента

                foreach (var item in condition._hashTable[i])
                {
                    bool isFound = condition.selectedItem != null && item.Key == condition.selectedItem.Key && item.Value == condition.selectedItem.Value;
                    if (isFound)
                    {
                        selectedItemIndex = currentIndex; // Сохраняем индекс найденного элемента
                    }
                    currentIndex++;
                }

                currentIndex = 0;
                foreach (var item in condition._hashTable[i])
                {
                    itemCount++;
                    bool isFound = currentIndex == selectedItemIndex; // Проверяем, является ли текущий элемент найденным
                    currentIndex++;

                    int currentX = startX + hashTableBucketWidth.Value + 10 + (itemCount - 1) * spacingX; // Текущая координата x для элемента
                    int currentY = startY + i * spacingY; // Текущая координата y для элемента
                    DrawHashTableItem(g, currentX, currentY, item, isFound);
                    g.DrawLine(pen, startX + hashTableBucketWidth.Value + 10 + (itemCount - 2) * spacingX + hashTableItemWidth.Value, startY + i * spacingY + hashTableBucketHeight.Value / 2, currentX, currentY + hashTableBucketHeight.Value / 2);
                }
            }
        }
    }
}
