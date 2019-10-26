import javax.swing.*;
import java.awt.*;
import java.awt.image.BufferedImage;

class BufferedOut {
    static void outBufferImg(BufferedImage img, int index)
    {
        BufferedImage newImg = new BufferedImage(img.getWidth()/index, img.getHeight()/index, BufferedImage.TYPE_INT_RGB);
        for (int i = 0, i1 = 0; i1 < img.getWidth(null); i++, i1+=index)
            for (int j = 0, j1 = 0; j1 < img.getHeight(null); j++, j1+=index)
            {
                try {

                    Color color = new Color(img.getRGB(i1, j1));
                    newImg.setRGB(i, j, color.getRGB());
                }
                catch (Exception ignored)
                {

                }
            }
        JFrame frame = new Main.SimpleWindow(newImg, "" + index);
        frame.setVisible(true);
        frame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
    }
}
