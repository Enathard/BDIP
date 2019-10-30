import javafx.application.Application;
import javafx.geometry.Side;
import javafx.scene.Scene;
import javafx.scene.chart.AreaChart;
import javafx.scene.chart.NumberAxis;
import javafx.scene.chart.XYChart;
import javafx.stage.Stage;

import javax.imageio.ImageIO;
import javax.swing.*;
import java.awt.*;
import java.awt.image.BufferedImage;
import java.io.File;
import java.io.IOException;
import java.util.Scanner;

public class BarChart extends Application {
    @Override
    public void start(Stage stage) throws IOException {
        BufferedImage img = Buffered.toBufferedImage(ImageIO.read(new File("C:\\Users\\Vladislav Zayats\\Desktop\\Lab1.jpg")));
        System.out.println("Введите процент зашумления");
        RandomReplacePixel.getReplacePixel(img, new Scanner(System.in).nextInt());

        String pathToImg = "save.jpg";
        BufferedImage newimg = ImageIO.read(new File(pathToImg));
        BufferedImage imageDynamicRange = ImageIO.read(new File(pathToImg));
        BufferedImage imageDynamicRangeLeft = ImageIO.read(new File(pathToImg));
        BufferedImage imageDynamicRangeRight = ImageIO.read(new File(pathToImg));
        final NumberAxis xAxis = new NumberAxis(0, 255, 1);
        final NumberAxis yAxis = new NumberAxis();//0,1,0.001);
        final AreaChart<Number, Number> areaChart = new AreaChart<>(xAxis, yAxis);
        areaChart.setTitle("Гистограмма");

        areaChart.setLegendSide(Side.LEFT);

        XYChart.Series<Number, Number> seriesOld = new XYChart.Series<>();
        seriesOld.setName("Гистограмма исходного изображения");
        XYChart.Series<Number, Number> seriesDynamicRange = new XYChart.Series<>();
        seriesDynamicRange.setName("Гистограмма с уменьшением диапозона в 2 раза");
        XYChart.Series<Number, Number> seriesDynamicRangeLeft = new XYChart.Series<>();
        seriesDynamicRangeLeft.setName("Гистограмма со смещением к минимум");
        XYChart.Series<Number, Number> seriesDynamicRangeRight = new XYChart.Series<>();
        seriesDynamicRangeRight.setName("Гистограмма со смещением к максимуму");

        Color color;
        double[] bufferOld = new double[256];
        double[] bufferDynamicRange = new double[256];
        double[] bufferDynamicRangeLeft = new double[256];
        double[] bufferDynamicRangeRight = new double[256];
        for (int i = 0; i < 256; i++) {
            bufferOld[i] = 0;
            bufferDynamicRange[i] = 0;
            bufferDynamicRangeLeft[i] = 0;
            bufferDynamicRangeRight[i] = 0;
        }
        for (int i = 0; i < imageDynamicRange.getWidth(); i++)
            for (int j = 0; j < imageDynamicRange.getHeight(); j++) {
                color = new Color(imageDynamicRange.getRGB(i, j));

                int index = (color.getRed() + color.getBlue() + color.getGreen()) / 3;
                ++bufferOld[index];

                imageDynamicRange.setRGB(i,j,new Color(color.getRed()/2+64, color.getGreen()/2+64,color.getBlue()/2+64).getRGB());
                ++bufferDynamicRange[index/2+64];

                imageDynamicRangeLeft.setRGB(i,j,new Color(color.getRed()/2, color.getGreen()/2,color.getBlue()/2).getRGB());
                ++bufferDynamicRangeLeft[index/2];

                imageDynamicRangeRight.setRGB(i,j,new Color(color.getRed()/2+64*2, color.getGreen()/2+64*2,color.getBlue()/2+64*2).getRGB());
                ++bufferDynamicRangeRight[index/2+64*2];
            }
        //double myMax = Arrays.stream(buffer).max().getAsDouble();
        for (int i = 0; i < 256; i++) {
            //buffer[i] /= myMax;
            seriesOld.getData().add(new XYChart.Data<>(i, bufferOld[i]));
            seriesDynamicRange.getData().add(new XYChart.Data<>(i, bufferDynamicRange[i]));
            seriesDynamicRangeLeft.getData().add(new XYChart.Data<>(i, bufferDynamicRangeLeft[i]));
            seriesDynamicRangeRight.getData().add(new XYChart.Data<>(i, bufferDynamicRangeRight[i]));
        }
        stage.setTitle("Гистограмма яркости");
        Scene scene = new Scene(areaChart, img.getWidth(), img.getHeight());
        areaChart.getData().add(seriesOld);
        areaChart.getData().add(seriesDynamicRange);
        areaChart.getData().add(seriesDynamicRangeLeft);
        areaChart.getData().add(seriesDynamicRangeRight);

        stage.setScene(scene);
        stage.show();

        new Main.SimpleWindow(newimg,"Исходное изображение");
        new Main.SimpleWindow(imageDynamicRange,"Уменьшенный диапозон в 2 раза");
        new Main.SimpleWindow(imageDynamicRangeLeft,"Исходное изображение со смещением к минимум");
        new Main.SimpleWindow(imageDynamicRangeRight,"Исходное изображение со смещением к максимуму");
    }
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
