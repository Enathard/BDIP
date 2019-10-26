import javax.swing.*;
import java.awt.*;
import java.awt.image.BufferedImage;
import java.io.IOException;

class SetsQuent {
    static void Quant(BufferedImage img, int index) throws IOException {
        Color color;
        for (int i = 0; i<img.getWidth(); i++)
            for (int j = 0; j < img.getHeight(); j++)
            {
                color = new Color(img.getRGB(i,j));
                if (color.getRed() % index != 0 && color.getRed() != 0)
                    img.setRGB(i, j, new Color(newColor(color.getRed(),index), color.getGreen(), color.getBlue()).getRGB());
                if (color.getBlue() % index != 0 && color.getBlue() != 0)
                    img.setRGB(i, j, new Color(color.getRed(), color.getGreen(), newColor(color.getBlue(),index)).getRGB());
                if (color.getGreen() % index != 0 && color.getGreen() != 0)
                    img.setRGB(i, j, new Color(color.getRed(), newColor(color.getGreen(),index), color.getBlue()).getRGB());
            }
        JFrame frame = new Main.SimpleWindow(img, "" + index);
        frame.setVisible(true);
        frame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
    }
    private static int newColor(int x, int index)
    {
        while(x%index != 0)
            x -= 1;
        return  x;
    }
}
