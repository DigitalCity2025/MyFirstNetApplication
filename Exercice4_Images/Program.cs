using ToolBox.Image;

int[,,] image = ImageUtils.GetPixel(@"C:\Users\K\Desktop\Aude\Images\sun.jpg");
// Créer une image en inversant les couleurs (Image en négatif)
// (100, 100, 100) (155, 155, 155)
//int[,,] result = new int[image.GetLength(0), image.GetLength(1), image.GetLength(2)];
//for (int i = 0; i < result.GetLength(0); i++)
//{
//    for (int j = 0; j < result.GetLength(1); j++)
//    {
//        for (int k = 0; k < result.GetLength(2); k++)
//        {
//            result[i,j,k] = 255 - image[i,j,k];
//        }
//    }
//}

//ImageUtils.CreateImage(@"C:\Users\K\Desktop\negatif.png", result);

// Créer une image en nuance de gris
// 0,2126 × Rouge + 0,7152 × Vert + 0,0722 × Bleu.

//int[,,] result = new int[image.GetLength(0), image.GetLength(1), image.GetLength(2)];

//for (int i = 0; i < result.GetLength(0); i++)
//{
//    for (int j = 0; j < result.GetLength(1); j++)
//    {
//        int gris = (int)(image[i, j, 0] * 0.2126 + image[i, j, 1] * 0.7152 + image[i, j, 2] * 0.0722);

//        for (int k = 0; k < result.GetLength(2); k++)
//        {
//            result[i, j, k] = gris;
//        }
//    }
//}
//ImageUtils.CreateImage(@"C:\Users\K\Desktop\gris.png", result);


// Créer une bordure noire de 10 pixels de large
//int[,,] result = new int[image.GetLength(0), image.GetLength(1), image.GetLength(2)];

//for (int i = 10; i < result.GetLength(0) - 10; i++)
//{
//    for (int j = 10; j < result.GetLength(1) - 10; j++)
//    {
//        for (int k = 0; k < result.GetLength(2); k++) 
//        {
//            result[i, j, k] = image[i, j, k];
//        }
//    }
//}
//int borderWidth = 10;
//for (int i = 0; i < image.GetLength(0); i++)
//{
//    for (int j = 0; j < borderWidth && j < image.GetLength(1); j++)
//    {
//        for (int k = 0; k < image.GetLength(2); k++)
//        {
//            image[i, j, k] = 0;
//            image[i, image.GetLength(1) - 1 - j, k] = 0;
//        }
//    }
//}

//for (int i = 0; i < borderWidth && i < image.GetLength(0); i++)
//{
//    for (int j = 0; j < image.GetLength(1); j++)
//    {
//        for (int k = 0; k < image.GetLength(2); k++)
//        {
//            image[i, j, k] = 0;
//            image[image.GetLength(0) - 1 - i, j, k] = 0;
//        }
//    }
//}

//ImageUtils.CreateImage(@"C:\Users\K\Desktop\bordure.png", image);

// Faire pivoter l'image de 90deg vers la droite
//int[,,] result = new int[image.GetLength(1), image.GetLength(0), image.GetLength(2)];

//for (int i = 0; i < image.GetLength(0); i++)
//{
//    for (int j = 0; j < image.GetLength(1); j++)
//    {
//        for (int k = 0; k < image.GetLength(2); k++)
//        {
//            result[j, i, k] = image[i, image.GetLength(1) - 1 - j, k];
//        }
//    }
//}

//ImageUtils.CreateImage(@"C:\Users\K\Desktop\test.png", result);

// Bonus: Algorithme Sobel
int[,] mx = { { -1, 0, 1 }, { -2, 0, 2 }, { -1, 0, 1 } };
int[,] my = { { -1, 2, -1 }, { 0, 0, 0 }, { 1, 2, 1 } };
int[,,] result = new int[image.GetLength(0), image.GetLength(1), image.GetLength(2)];

for (int i = 0; i < image.GetLength(0); i++)
{
    for (int j = 0; j < image.GetLength(1); j++)
    {
        int gx = 0;
        int gy = 0;
        for (int x = -1; x <= 1; x++)
        {
            for (int y = -1; y <= 1; y++) 
            {
                int dx = i + x;
                int dy = j + y;

                if(dx < 0 || dy < 0 || dx >= image.GetLength(0) || dy >= image.GetLength(1))
                {
                    continue;
                }

                int grey = (int)(image[dx, dy, 0] * 0.2126 + image[dx, dy, 1] * 0.7152 + image[dx, dy, 2] * 0.0722);

                gx += mx[y + 1, x + 1] * grey;
                gy += my[y + 1, x + 1] * grey;
            }
        }
        int value = (int)Math.Sqrt(Math.Pow(gx, 2) + Math.Pow(gy, 2));
        if(value > 255)
        {
            value = 255;
        }
        for (int k = 0; k < image.GetLength(2); k++)
        {
            result[i, j, k] = value;
        } 
    }
}

ImageUtils.CreateImage(@"C:\Users\K\Desktop\test.png", result);