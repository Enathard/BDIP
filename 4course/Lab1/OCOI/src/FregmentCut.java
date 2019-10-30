import javax.swing.*;
import java.awt.*;
import java.awt.image.BufferedImage;

class FregmentCut {
    static void getFragment(BufferedImage img) {
        // w 90 h 50 w 283 h 220
        BufferedImage newImg = new BufferedImage(80, 80, BufferedImage.TYPE_INT_RGB);
        Color color;
        for (int i = 160, i1 = 0; i < 240; i++, i1++)
            for (int j = 210, j1 = 0; j < 290; j++, j1++) {
                color = new Color(img.getRGB(i, j));
                newImg.setRGB(i1, j1, color.getRGB());
            }
        BufferedImage newNewImg = new BufferedImage(80*4, 80*4, BufferedImage.TYPE_INT_RGB);
        int index = 4;
        for (int i = 0, i1 = 0; i < 80; i++, i1+=4)
            for (int j = 0, j1 = 0; j < 80; j++, j1+=4)
            {
                color = new Color(newImg.getRGB(i, j));
                for(int k=0;k<index;k++)
                {
                    newNewImg.setRGB(i1+k, j1+k, color.getRGB());
                }
            }
        JFrame frame = new Main.SimpleWindow(newNewImg, "Вырезание и увеличение фрагмента");

        JFrame dwframe = new Main.SimpleWindow(img, "исходник");
        frame.setVisible(true);
        frame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
    }
}
