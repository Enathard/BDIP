import javax.swing.*;
import java.awt.*;
import java.awt.image.BufferedImage;

public class SetsContrans {
    static void getContrast(BufferedImage img) {
        Color color;

        for (int i = 0; i < img.getWidth(); i++)
            for (int j = 0; j < img.getHeight(); j++) {
                color = new Color(img.getRGB(i, j));
                int r = color.getRed();
                int b = color.getBlue();
                int g = color.getGreen();
                if (r >= 78) {
                    r = 78;
                } else if (r < 112) {
                    r = 112;
                }

                if (g >= 78) {
                    g = 78;
                } else if (g < 112) {
                    g = 112;
                }

                if (b >= 78) {
                    b = 78;
                } else if (b < 112) {
                    b = 112;
                }
                img.setRGB(i, j,new Color(r,g,b).getRGB());
            }
        JFrame frame = new Main.SimpleWindow(img, "Линейное контрастирование изображения ");
        frame.setVisible(true);
        frame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
    }
}
