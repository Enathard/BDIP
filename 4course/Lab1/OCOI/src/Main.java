import javax.imageio.ImageIO;
import javax.swing.*;
import java.awt.*;
import java.awt.event.*;
import java.awt.image.BufferedImage;
import java.io.File;
import java.io.IOException;
import java.util.Scanner;

public class Main {
    public static void main(String[] args) throws IOException{
        BufferedImage img = Buffered.toBufferedImage(ImageIO.read(new File("D:\\GSTU\\BDIP\\4course\\2.jpeg")));
        int i;

        System.out.println("Меню:");
        System.out.println("1. Квантование");
        System.out.println("2. Уменьшение изображения");
        System.out.println("3. Линейное контрастирование изображения ");
        System.out.println("4. Вырезать фрагмент изображения и увеличить в 4 раза");
        System.out.println("5. Случайным образом заменить значения яркости заданного процента пикселей");
        System.out.println("6. Преобразование изображения");
        i = new Scanner(System.in).nextInt();
        switch (i) {
            case 1: {
                SetsQuent.Quant(img, 1);
                SetsQuent.Quant(img, 8);
                SetsQuent.Quant(img, 16);
                SetsQuent.Quant(img, 32);
                SetsQuent.Quant(img, 64);
            }
            break;
            case 2: {
                BufferedOut.outBufferImg(img, 1);
                BufferedOut.outBufferImg(img, 2);
                BufferedOut.outBufferImg(img, 4);
                BufferedOut.outBufferImg(img, 8);
                BufferedOut.outBufferImg(img, 16);
            }
            break;
            case 3:
                SetsContrans.getContrast(img);
                break;
            case 4:
                FregmentCut.getFragment(img);
                break;
            case 5: {
                System.out.println("Введите процент изменения");
                RandomReplacePixel.getReplacePixel(img, new Scanner(System.in).nextInt());
            }
            break;
            case 6:
                ElementTransformation.getTranse(img);
                break;

        }
    }

    static class SimpleWindow extends JFrame {
        SimpleWindow(Image img, String str) {
            super(str);
            setDefaultCloseOperation(DO_NOTHING_ON_CLOSE);
            JPanel panel = new JPanel();
            panel.setLayout(new FlowLayout());
            JLabel label = new JLabel();
            label.setIcon(new ImageIcon(img));
            setVisible(true);
            panel.add(label);
            addWindowListener(new WindowAdapter() {
                @Override
                public void windowClosing(WindowEvent e) {
                    super.windowClosing(e);
                    dispose();
                }
            });
            setContentPane(panel);
            setSize(img.getWidth(null) + 20, img.getHeight(null) + 60);
        }
    }
}

