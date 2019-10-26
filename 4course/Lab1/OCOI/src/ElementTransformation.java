import javax.swing.*;
import java.awt.*;
import java.awt.image.BufferedImage;

class ElementTransformation {
    static void getTranse(BufferedImage img) {
        Color color;
        //int с = 30;
        for (int i = 0; i < img.getWidth(); i++)
            for (int j = 0; j < img.getHeight(); j++) {
                color = new Color(img.getRGB(i, j));
                int index = Math.abs(255 -(color.getRed() + color.getGreen() + color.getBlue())/3);
                if (index > 255) {
                    index = 255;
                } else if (index < 0) {
                    index = 0;
                }

                img.setRGB(i, j, new Color(index, index, index).getRGB());

            }
        JFrame frame = new Main.SimpleWindow(img, "Поэлементое преобразование(выризание диапозона яркостей)");
        frame.setVisible(true);
        frame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
    }
}

