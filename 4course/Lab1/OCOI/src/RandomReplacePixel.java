import javax.imageio.ImageIO;
import javax.swing.*;
import java.awt.*;
import java.awt.image.BufferedImage;
import java.io.File;
import java.io.IOException;

class RandomReplacePixel {
    static void getReplacePixel(BufferedImage img, int percent) throws IOException {
        int n = img.getHeight()*img.getWidth() * percent / 100;
        int maxWidth = img.getWidth(), maxHeight = img.getHeight();
        for (int i = 0; i < n/2; i++) {
            img.setRGB((int) (Math.random() * maxWidth), (int) (Math.random() * maxHeight), new Color(0,0,0).getRGB());
            img.setRGB((int) (Math.random() * maxWidth), (int) (Math.random() * maxHeight), new Color(255,255,255).getRGB());
        }
        ImageIO.write(img,"jpg",new File("save.jpg"));
        /*JFrame frame = new Main.SimpleWindow(img, "RandomReplacePixel");
        frame.setVisible(true);
        frame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);*/
    }
}