package com.company;

// src https://refactoring.guru/ru/design-patterns/factory-method

public class Main {
    private static Dialog dialog;

    public static void main(String[] args) {
        configure();
        runBusinessLogic();
    }

    static void configure(){
        if (System.getProperty("os.name").equals("Linux") ||
            System.getProperty("os.name").equals("Windows 10")){
            dialog = new DesktopDialog();
        }
        else {
            dialog = new HtmlDialog();
        }
    }

    static void runBusinessLogic(){
        dialog.renderWindow();
    }
}
