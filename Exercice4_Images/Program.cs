using ToolBox.Image;

int[,,] images = ImageUtils.GetPixel(@"C:\Users\K\Desktop\Aude\images\plateau fromages 916_00000.jpg");
// Créer une image en inversant les couleurs (Image en négatif)
// (100, 100, 100) (155, 155, 155)
//int[,,] result = new int[images.GetLength(0), images.GetLength(1), images.GetLength(2)];
//for (int i = 0; i < result.GetLength(0); i++)
//{
//    for (int j = 0; j < result.GetLength(1); j++)
//    {
//        for (int k = 0; k < result.GetLength(2); k++)
//        {
//            result[i,j,k] = 255 - images[i,j,k];
//        }
//    }
//}

//ImageUtils.CreateImage(@"C:\Users\K\Desktop\negatif.png", result);

// Créer une image en nuance de gris
// 0,2126 × Rouge + 0,7152 × Vert + 0,0722 × Bleu.

//int[,,] result = new int[images.GetLength(0), images.GetLength(1), images.GetLength(2)];

//for (int i = 0; i < result.GetLength(0); i++)
//{
//    for (int j = 0; j < result.GetLength(1); j++)
//    {
//        int gris = (int)(images[i, j, 0] * 0.2126 + images[i, j, 1] * 0.7152 + images[i, j, 2] * 0.0722);

//        for (int k = 0; k < result.GetLength(2); k++)
//        {
//            result[i, j, k] = gris;
//        }
//    }
//}
//ImageUtils.CreateImage(@"C:\Users\K\Desktop\gris.png", result);


// Créer une bordure noire de 10 pixels de large
//int[,,] result = new int[images.GetLength(0), images.GetLength(1), images.GetLength(2)];

//for (int i = 10; i < result.GetLength(0) - 10; i++)
//{
//    for (int j = 10; j < result.GetLength(1) - 10; j++)
//    {
//        for (int k = 0; k < result.GetLength(2); k++) 
//        {
//            result[i, j, k] = images[i, j, k];
//        }
//    }
//}
//int borderWidth = 10;
//for (int i = 0; i < images.GetLength(0); i++)
//{
//    for (int j = 0; j < borderWidth && j < images.GetLength(1); j++)
//    {
//        for (int k = 0; k < images.GetLength(2); k++)
//        {
//            images[i, j, k] = 0;
//            images[i, images.GetLength(1) - 1 - j, k] = 0;
//        }
//    }
//}

//for (int i = 0; i < borderWidth && i < images.GetLength(0); i++)
//{
//    for (int j = 0; j < images.GetLength(1); j++)
//    {
//        for (int k = 0; k < images.GetLength(2); k++)
//        {
//            images[i, j, k] = 0;
//            images[images.GetLength(0) - 1 - i, j, k] = 0;
//        }
//    }
//}

//ImageUtils.CreateImage(@"C:\Users\K\Desktop\bordure.png", images);

// Faire pivoter l'image de 90deg vers la droite
int[,,] result = new int[images.GetLength(1), images.GetLength(0), images.GetLength(2)];

for (int i = 0; i < images.GetLength(0); i++)
{
    for (int j = 0; j < images.GetLength(1); j++)
    {
        for (int k = 0; k < images.GetLength(2); k++)
        {
            result[j, i, k] = images[i, images.GetLength(1) - 1 - j, k];
        }
    }
}

ImageUtils.CreateImage(@"C:\Users\K\Desktop\test.png", result);

// Bonus: Algorithme Sobel