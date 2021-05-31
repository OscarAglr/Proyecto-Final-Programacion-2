/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package duarte.programacion2.finalproject.series.PnlAnualidades.controllers;

import duarte.programacion2.finalproject.series.PnlAnualidades.PnlAnualidadTemplate;
import duarte.programacion2.finalproject.series.PnlAnualidades.core.Anualidades;
import java.awt.Color;
import java.awt.event.FocusAdapter;
import java.awt.event.FocusEvent;
import java.awt.event.KeyAdapter;
import java.awt.event.KeyEvent;
import java.text.DecimalFormat;
import javax.swing.DefaultComboBoxModel;

/**
 *
 * @author dell
 */
public class PnlAnualidadAnticipadaController {

    private final PnlAnualidadTemplate anualidadAnticipada;
    private DefaultComboBoxModel cmbTipoPeriodicaModel;
    private DefaultComboBoxModel cmbPeriodosModel;
    private final String[] tipoDeTasa = {"BIMESTRAL", "TRIMESTRAL", "CUATRIMESTRAL", "SEMESTRAL", "MENSUAL"};
    private final String[] periodos = {"BIMESTRES", "TRIMESTRES", "CUATRIMESTRES", "SEMESTRES", "MENSES", "AÑOS"};

    private DecimalFormat format;

    public PnlAnualidadAnticipadaController(PnlAnualidadTemplate anualidadAnticipada) {
        this.anualidadAnticipada = anualidadAnticipada;
        initComponent();
    }

    private void initComponent() {

        cmbTipoPeriodicaModel = new DefaultComboBoxModel(tipoDeTasa);
        anualidadAnticipada.getCmbTipoPeriodica().setModel(cmbTipoPeriodicaModel);

        cmbPeriodosModel = new DefaultComboBoxModel(periodos);
        anualidadAnticipada.getCmbPeriodos().setModel(cmbPeriodosModel);

        format = new DecimalFormat("#.##");

        anualidadAnticipada.getRbtnVF().addActionListener((e) -> {
            anualidadAnticipada.getTxtValor().setEnabled(true);

            if (anualidadAnticipada.getTxtValor().getText().equalsIgnoreCase("digite el valor")) {
                anualidadAnticipada.getTxtValor().requestFocus();
            }

            CalcularAnualidadActionPerformed();
        });

        anualidadAnticipada.getRbtnVP().addActionListener((e) -> {
            anualidadAnticipada.getTxtValor().setEnabled(true);
            if (anualidadAnticipada.getTxtValor().getText().equalsIgnoreCase("digite el valor")) {
                anualidadAnticipada.getTxtValor().requestFocus();
            }
            CalcularAnualidadActionPerformed();
        });

        anualidadAnticipada.getRbtnPeriodica().addActionListener((e) -> {
            anualidadAnticipada.getCmbTipoPeriodica().setEnabled(true);
            anualidadAnticipada.getTxtTasa().setEnabled(true);
            anualidadAnticipada.getLblProcentaje().setEnabled(true);

            if (anualidadAnticipada.getTxtTasa().getText().equalsIgnoreCase("digite la tasa")) {
                anualidadAnticipada.getTxtTasa().requestFocus();
            }

            CalcularAnualidadActionPerformed();
        });

        anualidadAnticipada.getRbtnAnual().addActionListener((e) -> {
            anualidadAnticipada.getCmbTipoPeriodica().setEnabled(false);
            anualidadAnticipada.getTxtTasa().setEnabled(true);
            anualidadAnticipada.getLblProcentaje().setEnabled(true);

            if (anualidadAnticipada.getTxtTasa().getText().equalsIgnoreCase("digite la tasa")) {
                anualidadAnticipada.getTxtTasa().requestFocus();
            }

            CalcularAnualidadActionPerformed();
        });

        anualidadAnticipada.getTxtValor().addKeyListener(new KeyAdapter() {
            @Override
            public void keyTyped(KeyEvent e) {
                char value = e.getKeyChar();
                if (!Character.isDigit(value) && value != '.') {
                    e.consume();
                    return;
                }
                if (value == '.' && anualidadAnticipada.getTxtValor().getText().contains(".")) {
                    e.consume();
                }
            }

            @Override
            public void keyReleased(KeyEvent e) {
                CalcularAnualidadActionPerformed();
            }
        });

        anualidadAnticipada.getTxtTasa().addKeyListener(new KeyAdapter() {
            @Override
            public void keyTyped(KeyEvent e) {
                char value = e.getKeyChar();
                if (!Character.isDigit(value) && value != '.') {
                    e.consume();
                    return;
                }
                if (value == '.' && anualidadAnticipada.getTxtTasa().getText().contains(".")) {
                    e.consume();
                }
            }

            @Override
            public void keyReleased(KeyEvent e) {
                CalcularAnualidadActionPerformed();
            }
        });

        anualidadAnticipada.getTxtPeriodos().addKeyListener(new KeyAdapter() {
            @Override
            public void keyTyped(KeyEvent e) {
                char value = e.getKeyChar();
                if (!Character.isDigit(value) && value != '.') {
                    e.consume();
                    return;
                }
                if (value == '.' && anualidadAnticipada.getTxtPeriodos().getText().contains(".")) {
                    e.consume();
                }
            }

            @Override
            public void keyReleased(KeyEvent e) {
                CalcularAnualidadActionPerformed();
            }
        });

        anualidadAnticipada.getTxtValor().addFocusListener(new FocusAdapter() {
            @Override
            public void focusGained(FocusEvent e) {
                anualidadAnticipada.getTxtValor().setText("");
                anualidadAnticipada.getTxtValor().setForeground(Color.BLACK);

                anualidadAnticipada.getFmdtResultado().setText("NaN");
                anualidadAnticipada.getFmdtResultado().setForeground(Color.GRAY);
            }

            @Override
            public void focusLost(FocusEvent e) {
                if (!anualidadAnticipada.getTxtValor().getText().isBlank()) {
                    return;
                }
                anualidadAnticipada.getTxtValor().setText("Digite el Valor");
                anualidadAnticipada.getTxtValor().setForeground(Color.GRAY);
            }
        });
        anualidadAnticipada.getTxtTasa().addFocusListener(new FocusAdapter() {
            @Override
            public void focusGained(FocusEvent e) {
                anualidadAnticipada.getTxtTasa().setText("");
                anualidadAnticipada.getTxtTasa().setForeground(Color.BLACK);

                anualidadAnticipada.getFmdtResultado().setText("NaN");
                anualidadAnticipada.getFmdtResultado().setForeground(Color.GRAY);
            }

            @Override
            public void focusLost(FocusEvent e) {
                if (!anualidadAnticipada.getTxtTasa().getText().isBlank()) {
                    return;
                }
                anualidadAnticipada.getTxtTasa().setText("Digite la Tasa");
                anualidadAnticipada.getTxtTasa().setForeground(Color.GRAY);
            }
        });

        anualidadAnticipada.getTxtPeriodos().addFocusListener(new FocusAdapter() {
            @Override
            public void focusGained(FocusEvent e) {
                anualidadAnticipada.getTxtPeriodos().setText("");
                anualidadAnticipada.getTxtPeriodos().setForeground(Color.BLACK);

                anualidadAnticipada.getFmdtResultado().setText("NaN");
                anualidadAnticipada.getFmdtResultado().setForeground(Color.GRAY);
            }

            @Override
            public void focusLost(FocusEvent e) {
                if (!anualidadAnticipada.getTxtPeriodos().getText().isBlank()) {
                    return;
                }
                anualidadAnticipada.getTxtPeriodos().setText("N° de periodos");
                anualidadAnticipada.getTxtPeriodos().setForeground(Color.GRAY);
            }
        });

        anualidadAnticipada.getCmbPeriodos().addItemListener((e) -> {
            CalcularAnualidadActionPerformed();
        });

        anualidadAnticipada.getCmbTipoPeriodica().addItemListener((e) -> {
            CalcularAnualidadActionPerformed();
        });

    }

    private void CalcularAnualidadActionPerformed() {

        if (anualidadAnticipada.getRbtnVF().isSelected()) {
            if (anualidadAnticipada.getRbtnAnual().isSelected()) {

                switch (anualidadAnticipada.getCmbPeriodos().getSelectedIndex()) {
                    case 0 -> {
                        anualidadAnticipada.getFmdtResultado().setText(String.valueOf(format.format(Anualidades.anticipadaValorFuturoTasaAnual(
                                Float.parseFloat(anualidadAnticipada.getTxtTasa().getText()), Float.parseFloat(anualidadAnticipada.getTxtValor().getText()), Float.parseFloat(anualidadAnticipada.getTxtPeriodos().getText()), 6))));
                    }
                    case 1 -> {
                        anualidadAnticipada.getFmdtResultado().setText(String.valueOf(format.format(Anualidades.anticipadaValorFuturoTasaAnual(
                                Float.parseFloat(anualidadAnticipada.getTxtTasa().getText()), Float.parseFloat(anualidadAnticipada.getTxtValor().getText()), Float.parseFloat(anualidadAnticipada.getTxtPeriodos().getText()), 4))));
                    }
                    case 2 -> {
                        anualidadAnticipada.getFmdtResultado().setText(String.valueOf(format.format(Anualidades.anticipadaValorFuturoTasaAnual(
                                Float.parseFloat(anualidadAnticipada.getTxtTasa().getText()), Float.parseFloat(anualidadAnticipada.getTxtValor().getText()), Float.parseFloat(anualidadAnticipada.getTxtPeriodos().getText()), 3))));
                    }
                    case 3 -> {
                        anualidadAnticipada.getFmdtResultado().setText(String.valueOf(format.format(Anualidades.anticipadaValorFuturoTasaAnual(
                                Float.parseFloat(anualidadAnticipada.getTxtTasa().getText()), Float.parseFloat(anualidadAnticipada.getTxtValor().getText()), Float.parseFloat(anualidadAnticipada.getTxtPeriodos().getText()), 2))));
                    }
                    case 4 -> {
                        anualidadAnticipada.getFmdtResultado().setText(String.valueOf(format.format(Anualidades.anticipadaValorFuturoTasaAnual(
                                Float.parseFloat(anualidadAnticipada.getTxtTasa().getText()), Float.parseFloat(anualidadAnticipada.getTxtValor().getText()), Float.parseFloat(anualidadAnticipada.getTxtPeriodos().getText()), 12))));
                    }
                    case 5 -> {
                        anualidadAnticipada.getFmdtResultado().setText(String.valueOf(format.format(Anualidades.anticipadaValorFuturoTasaAnual(
                                Float.parseFloat(anualidadAnticipada.getTxtTasa().getText()), Float.parseFloat(anualidadAnticipada.getTxtValor().getText()), Float.parseFloat(anualidadAnticipada.getTxtPeriodos().getText()), 1))));
                    }
                }
            } else if (anualidadAnticipada.getRbtnPeriodica().isSelected()) {
                switch (anualidadAnticipada.getCmbTipoPeriodica().getSelectedIndex()) {

                    case 0 -> {

                        switch (anualidadAnticipada.getCmbPeriodos().getSelectedIndex()) {
                            case 0 -> {
                                anualidadAnticipada.getFmdtResultado().setText(String.valueOf(format.format(Anualidades.anticipadaValorFuturoTasaPeriodica(
                                        Float.parseFloat(anualidadAnticipada.getTxtTasa().getText()), Float.parseFloat(anualidadAnticipada.getTxtValor().getText()), Float.parseFloat(anualidadAnticipada.getTxtPeriodos().getText()), 6, 6))));
                            }
                            case 1 -> {
                                anualidadAnticipada.getFmdtResultado().setText(String.valueOf(format.format(Anualidades.anticipadaValorFuturoTasaPeriodica(
                                        Float.parseFloat(anualidadAnticipada.getTxtTasa().getText()), Float.parseFloat(anualidadAnticipada.getTxtValor().getText()), Float.parseFloat(anualidadAnticipada.getTxtPeriodos().getText()), 6, 4))));
                            }
                            case 2 -> {
                                anualidadAnticipada.getFmdtResultado().setText(String.valueOf(format.format(Anualidades.anticipadaValorFuturoTasaPeriodica(
                                        Float.parseFloat(anualidadAnticipada.getTxtTasa().getText()), Float.parseFloat(anualidadAnticipada.getTxtValor().getText()), Float.parseFloat(anualidadAnticipada.getTxtPeriodos().getText()), 6, 3))));
                            }
                            case 3 -> {
                                anualidadAnticipada.getFmdtResultado().setText(String.valueOf(format.format(Anualidades.anticipadaValorFuturoTasaPeriodica(
                                        Float.parseFloat(anualidadAnticipada.getTxtTasa().getText()), Float.parseFloat(anualidadAnticipada.getTxtValor().getText()), Float.parseFloat(anualidadAnticipada.getTxtPeriodos().getText()), 6, 2))));
                            }
                            case 4 -> {
                                anualidadAnticipada.getFmdtResultado().setText(String.valueOf(format.format(Anualidades.anticipadaValorFuturoTasaPeriodica(
                                        Float.parseFloat(anualidadAnticipada.getTxtTasa().getText()), Float.parseFloat(anualidadAnticipada.getTxtValor().getText()), Float.parseFloat(anualidadAnticipada.getTxtPeriodos().getText()), 6, 12))));
                            }
                            case 5 -> {
                                anualidadAnticipada.getFmdtResultado().setText(String.valueOf(format.format(Anualidades.anticipadaValorFuturoTasaPeriodica(
                                        Float.parseFloat(anualidadAnticipada.getTxtTasa().getText()), Float.parseFloat(anualidadAnticipada.getTxtValor().getText()), Float.parseFloat(anualidadAnticipada.getTxtPeriodos().getText()), 6, 1))));
                            }

                        }
                    }
                    case 1 -> {
                        switch (anualidadAnticipada.getCmbPeriodos().getSelectedIndex()) {
                            case 0 -> {
                                anualidadAnticipada.getFmdtResultado().setText(String.valueOf(format.format(Anualidades.anticipadaValorFuturoTasaPeriodica(
                                        Float.parseFloat(anualidadAnticipada.getTxtTasa().getText()), Float.parseFloat(anualidadAnticipada.getTxtValor().getText()), Float.parseFloat(anualidadAnticipada.getTxtPeriodos().getText()), 4, 6))));
                            }
                            case 1 -> {
                                anualidadAnticipada.getFmdtResultado().setText(String.valueOf(format.format(Anualidades.anticipadaValorFuturoTasaPeriodica(
                                        Float.parseFloat(anualidadAnticipada.getTxtTasa().getText()), Float.parseFloat(anualidadAnticipada.getTxtValor().getText()), Float.parseFloat(anualidadAnticipada.getTxtPeriodos().getText()), 4, 4))));
                            }
                            case 2 -> {
                                anualidadAnticipada.getFmdtResultado().setText(String.valueOf(format.format(Anualidades.anticipadaValorFuturoTasaPeriodica(
                                        Float.parseFloat(anualidadAnticipada.getTxtTasa().getText()), Float.parseFloat(anualidadAnticipada.getTxtValor().getText()), Float.parseFloat(anualidadAnticipada.getTxtPeriodos().getText()), 4, 3))));
                            }
                            case 3 -> {
                                anualidadAnticipada.getFmdtResultado().setText(String.valueOf(format.format(Anualidades.anticipadaValorFuturoTasaPeriodica(
                                        Float.parseFloat(anualidadAnticipada.getTxtTasa().getText()), Float.parseFloat(anualidadAnticipada.getTxtValor().getText()), Float.parseFloat(anualidadAnticipada.getTxtPeriodos().getText()), 4, 2))));
                            }
                            case 4 -> {
                                anualidadAnticipada.getFmdtResultado().setText(String.valueOf(format.format(Anualidades.anticipadaValorFuturoTasaPeriodica(
                                        Float.parseFloat(anualidadAnticipada.getTxtTasa().getText()), Float.parseFloat(anualidadAnticipada.getTxtValor().getText()), Float.parseFloat(anualidadAnticipada.getTxtPeriodos().getText()), 4, 12))));
                            }
                            case 5 -> {
                                anualidadAnticipada.getFmdtResultado().setText(String.valueOf(format.format(Anualidades.anticipadaValorFuturoTasaPeriodica(
                                        Float.parseFloat(anualidadAnticipada.getTxtTasa().getText()), Float.parseFloat(anualidadAnticipada.getTxtValor().getText()), Float.parseFloat(anualidadAnticipada.getTxtPeriodos().getText()), 4, 1))));
                            }
                        }
                    }
                    case 2 -> {
                        switch (anualidadAnticipada.getCmbPeriodos().getSelectedIndex()) {
                            case 0 -> {
                                anualidadAnticipada.getFmdtResultado().setText(String.valueOf(format.format(Anualidades.anticipadaValorFuturoTasaPeriodica(
                                        Float.parseFloat(anualidadAnticipada.getTxtTasa().getText()), Float.parseFloat(anualidadAnticipada.getTxtValor().getText()), Float.parseFloat(anualidadAnticipada.getTxtPeriodos().getText()), 3, 6))));
                            }
                            case 1 -> {
                                anualidadAnticipada.getFmdtResultado().setText(String.valueOf(format.format(Anualidades.anticipadaValorFuturoTasaPeriodica(
                                        Float.parseFloat(anualidadAnticipada.getTxtTasa().getText()), Float.parseFloat(anualidadAnticipada.getTxtValor().getText()), Float.parseFloat(anualidadAnticipada.getTxtPeriodos().getText()), 3, 4))));
                            }
                            case 2 -> {
                                anualidadAnticipada.getFmdtResultado().setText(String.valueOf(format.format(Anualidades.anticipadaValorFuturoTasaPeriodica(
                                        Float.parseFloat(anualidadAnticipada.getTxtTasa().getText()), Float.parseFloat(anualidadAnticipada.getTxtValor().getText()), Float.parseFloat(anualidadAnticipada.getTxtPeriodos().getText()), 3, 3))));
                            }
                            case 3 -> {
                                anualidadAnticipada.getFmdtResultado().setText(String.valueOf(format.format(Anualidades.anticipadaValorFuturoTasaPeriodica(
                                        Float.parseFloat(anualidadAnticipada.getTxtTasa().getText()), Float.parseFloat(anualidadAnticipada.getTxtValor().getText()), Float.parseFloat(anualidadAnticipada.getTxtPeriodos().getText()), 3, 2))));
                            }
                            case 4 -> {
                                anualidadAnticipada.getFmdtResultado().setText(String.valueOf(format.format(Anualidades.anticipadaValorFuturoTasaPeriodica(
                                        Float.parseFloat(anualidadAnticipada.getTxtTasa().getText()), Float.parseFloat(anualidadAnticipada.getTxtValor().getText()), Float.parseFloat(anualidadAnticipada.getTxtPeriodos().getText()), 3, 12))));
                            }
                            case 5 -> {

                                anualidadAnticipada.getFmdtResultado().setText(String.valueOf(format.format(Anualidades.anticipadaValorFuturoTasaPeriodica(
                                        Float.parseFloat(anualidadAnticipada.getTxtTasa().getText()), Float.parseFloat(anualidadAnticipada.getTxtValor().getText()), Float.parseFloat(anualidadAnticipada.getTxtPeriodos().getText()), 3, 1))));
                            }
                        }
                    }
                    case 3 -> {
                        switch (anualidadAnticipada.getCmbPeriodos().getSelectedIndex()) {
                            case 0 -> {
                                anualidadAnticipada.getFmdtResultado().setText(String.valueOf(format.format(Anualidades.anticipadaValorFuturoTasaPeriodica(
                                        Float.parseFloat(anualidadAnticipada.getTxtTasa().getText()), Float.parseFloat(anualidadAnticipada.getTxtValor().getText()), Float.parseFloat(anualidadAnticipada.getTxtPeriodos().getText()), 2, 6))));
                            }
                            case 1 -> {
                                anualidadAnticipada.getFmdtResultado().setText(String.valueOf(format.format(Anualidades.anticipadaValorFuturoTasaPeriodica(
                                        Float.parseFloat(anualidadAnticipada.getTxtTasa().getText()), Float.parseFloat(anualidadAnticipada.getTxtValor().getText()), Float.parseFloat(anualidadAnticipada.getTxtPeriodos().getText()), 2, 4))));
                            }
                            case 2 -> {
                                anualidadAnticipada.getFmdtResultado().setText(String.valueOf(format.format(Anualidades.anticipadaValorFuturoTasaPeriodica(
                                        Float.parseFloat(anualidadAnticipada.getTxtTasa().getText()), Float.parseFloat(anualidadAnticipada.getTxtValor().getText()), Float.parseFloat(anualidadAnticipada.getTxtPeriodos().getText()), 2, 3))));
                            }
                            case 3 -> {
                                anualidadAnticipada.getFmdtResultado().setText(String.valueOf(format.format(Anualidades.anticipadaValorFuturoTasaPeriodica(
                                        Float.parseFloat(anualidadAnticipada.getTxtTasa().getText()), Float.parseFloat(anualidadAnticipada.getTxtValor().getText()), Float.parseFloat(anualidadAnticipada.getTxtPeriodos().getText()), 2, 2))));
                            }
                            case 4 -> {
                                anualidadAnticipada.getFmdtResultado().setText(String.valueOf(format.format(Anualidades.anticipadaValorFuturoTasaPeriodica(
                                        Float.parseFloat(anualidadAnticipada.getTxtTasa().getText()), Float.parseFloat(anualidadAnticipada.getTxtValor().getText()), Float.parseFloat(anualidadAnticipada.getTxtPeriodos().getText()), 2, 12))));
                            }
                            case 5 -> {
                                anualidadAnticipada.getFmdtResultado().setText(String.valueOf(format.format(Anualidades.anticipadaValorFuturoTasaPeriodica(
                                        Float.parseFloat(anualidadAnticipada.getTxtTasa().getText()), Float.parseFloat(anualidadAnticipada.getTxtValor().getText()), Float.parseFloat(anualidadAnticipada.getTxtPeriodos().getText()), 2, 1))));
                            }
                        }
                    }
                    case 4 -> {

                        switch (anualidadAnticipada.getCmbPeriodos().getSelectedIndex()) {
                            case 0 -> {
                                anualidadAnticipada.getFmdtResultado().setText(String.valueOf(format.format(Anualidades.anticipadaValorFuturoTasaPeriodica(
                                        Float.parseFloat(anualidadAnticipada.getTxtTasa().getText()), Float.parseFloat(anualidadAnticipada.getTxtValor().getText()), Float.parseFloat(anualidadAnticipada.getTxtPeriodos().getText()), 12, 6))));
                            }
                            case 1 -> {
                                anualidadAnticipada.getFmdtResultado().setText(String.valueOf(format.format(Anualidades.anticipadaValorFuturoTasaPeriodica(
                                        Float.parseFloat(anualidadAnticipada.getTxtTasa().getText()), Float.parseFloat(anualidadAnticipada.getTxtValor().getText()), Float.parseFloat(anualidadAnticipada.getTxtPeriodos().getText()), 12, 4))));
                            }
                            case 2 -> {
                                anualidadAnticipada.getFmdtResultado().setText(String.valueOf(format.format(Anualidades.anticipadaValorFuturoTasaPeriodica(
                                        Float.parseFloat(anualidadAnticipada.getTxtTasa().getText()), Float.parseFloat(anualidadAnticipada.getTxtValor().getText()), Float.parseFloat(anualidadAnticipada.getTxtPeriodos().getText()), 12, 3))));
                            }
                            case 3 -> {
                                anualidadAnticipada.getFmdtResultado().setText(String.valueOf(format.format(Anualidades.anticipadaValorFuturoTasaPeriodica(
                                        Float.parseFloat(anualidadAnticipada.getTxtTasa().getText()), Float.parseFloat(anualidadAnticipada.getTxtValor().getText()), Float.parseFloat(anualidadAnticipada.getTxtPeriodos().getText()), 12, 2))));
                            }
                            case 4 -> {
                                anualidadAnticipada.getFmdtResultado().setText(String.valueOf(format.format(Anualidades.anticipadaValorFuturoTasaPeriodica(
                                        Float.parseFloat(anualidadAnticipada.getTxtTasa().getText()), Float.parseFloat(anualidadAnticipada.getTxtValor().getText()), Float.parseFloat(anualidadAnticipada.getTxtPeriodos().getText()), 12, 12))));
                            }
                            case 5 -> {
                                anualidadAnticipada.getFmdtResultado().setText(String.valueOf(format.format(Anualidades.anticipadaValorFuturoTasaPeriodica(
                                        Float.parseFloat(anualidadAnticipada.getTxtTasa().getText()), Float.parseFloat(anualidadAnticipada.getTxtValor().getText()), Float.parseFloat(anualidadAnticipada.getTxtPeriodos().getText()), 12, 1))));
                            }
                        }
                    }
                }
            }
        } else if (anualidadAnticipada.getRbtnVP().isSelected()) {

            if (anualidadAnticipada.getRbtnAnual().isSelected()) {
                switch (anualidadAnticipada.getCmbPeriodos().getSelectedIndex()) {
                    case 0 -> {
                        anualidadAnticipada.getFmdtResultado().setText(String.valueOf(format.format(Anualidades.anticipadaValorPresenteTasaAnual(
                                Float.parseFloat(anualidadAnticipada.getTxtTasa().getText()), Float.parseFloat(anualidadAnticipada.getTxtValor().getText()), Float.parseFloat(anualidadAnticipada.getTxtPeriodos().getText()), 6))));
                    }
                    case 1 -> {
                        anualidadAnticipada.getFmdtResultado().setText(String.valueOf(format.format(Anualidades.anticipadaValorPresenteTasaAnual(
                                Float.parseFloat(anualidadAnticipada.getTxtTasa().getText()), Float.parseFloat(anualidadAnticipada.getTxtValor().getText()), Float.parseFloat(anualidadAnticipada.getTxtPeriodos().getText()), 4))));

                    }
                    case 2 -> {
                        anualidadAnticipada.getFmdtResultado().setText(String.valueOf(format.format(Anualidades.anticipadaValorPresenteTasaAnual(
                                Float.parseFloat(anualidadAnticipada.getTxtTasa().getText()), Float.parseFloat(anualidadAnticipada.getTxtValor().getText()), Float.parseFloat(anualidadAnticipada.getTxtPeriodos().getText()), 3))));

                    }
                    case 3 -> {
                        anualidadAnticipada.getFmdtResultado().setText(String.valueOf(format.format(Anualidades.anticipadaValorPresenteTasaAnual(
                                Float.parseFloat(anualidadAnticipada.getTxtTasa().getText()), Float.parseFloat(anualidadAnticipada.getTxtValor().getText()), Float.parseFloat(anualidadAnticipada.getTxtPeriodos().getText()), 2))));

                    }
                    case 4 -> {
                        anualidadAnticipada.getFmdtResultado().setText(String.valueOf(format.format(Anualidades.anticipadaValorPresenteTasaAnual(
                                Float.parseFloat(anualidadAnticipada.getTxtTasa().getText()), Float.parseFloat(anualidadAnticipada.getTxtValor().getText()), Float.parseFloat(anualidadAnticipada.getTxtPeriodos().getText()), 12))));

                    }
                    case 5 -> {
                        anualidadAnticipada.getFmdtResultado().setText(String.valueOf(format.format(Anualidades.anticipadaValorPresenteTasaAnual(
                                Float.parseFloat(anualidadAnticipada.getTxtTasa().getText()), Float.parseFloat(anualidadAnticipada.getTxtValor().getText()), Float.parseFloat(anualidadAnticipada.getTxtPeriodos().getText()), 1))));

                    }
                }
            } else if (anualidadAnticipada.getRbtnPeriodica().isSelected()) {
                switch (anualidadAnticipada.getCmbTipoPeriodica().getSelectedIndex()) {

                    case 0 -> {

                        switch (anualidadAnticipada.getCmbPeriodos().getSelectedIndex()) {
                            case 0 -> {
                                anualidadAnticipada.getFmdtResultado().setText(String.valueOf(format.format(Anualidades.anticipadaValorPresenteTasaPeriodica(
                                        Float.parseFloat(anualidadAnticipada.getTxtTasa().getText()), Float.parseFloat(anualidadAnticipada.getTxtValor().getText()), Float.parseFloat(anualidadAnticipada.getTxtPeriodos().getText()), 6, 6))));
                            }
                            case 1 -> {
                                anualidadAnticipada.getFmdtResultado().setText(String.valueOf(format.format(Anualidades.anticipadaValorPresenteTasaPeriodica(
                                        Float.parseFloat(anualidadAnticipada.getTxtTasa().getText()), Float.parseFloat(anualidadAnticipada.getTxtValor().getText()), Float.parseFloat(anualidadAnticipada.getTxtPeriodos().getText()), 6, 4))));
                            }
                            case 2 -> {
                                anualidadAnticipada.getFmdtResultado().setText(String.valueOf(format.format(Anualidades.anticipadaValorPresenteTasaPeriodica(
                                        Float.parseFloat(anualidadAnticipada.getTxtTasa().getText()), Float.parseFloat(anualidadAnticipada.getTxtValor().getText()), Float.parseFloat(anualidadAnticipada.getTxtPeriodos().getText()), 6, 3))));
                            }
                            case 3 -> {
                                anualidadAnticipada.getFmdtResultado().setText(String.valueOf(format.format(Anualidades.anticipadaValorPresenteTasaPeriodica(
                                        Float.parseFloat(anualidadAnticipada.getTxtTasa().getText()), Float.parseFloat(anualidadAnticipada.getTxtValor().getText()), Float.parseFloat(anualidadAnticipada.getTxtPeriodos().getText()), 6, 2))));
                            }
                            case 4 -> {
                                anualidadAnticipada.getFmdtResultado().setText(String.valueOf(format.format(Anualidades.anticipadaValorPresenteTasaPeriodica(
                                        Float.parseFloat(anualidadAnticipada.getTxtTasa().getText()), Float.parseFloat(anualidadAnticipada.getTxtValor().getText()), Float.parseFloat(anualidadAnticipada.getTxtPeriodos().getText()), 6, 12))));
                            }
                            case 5 -> {
                                anualidadAnticipada.getFmdtResultado().setText(String.valueOf(format.format(Anualidades.anticipadaValorPresenteTasaPeriodica(
                                        Float.parseFloat(anualidadAnticipada.getTxtTasa().getText()), Float.parseFloat(anualidadAnticipada.getTxtValor().getText()), Float.parseFloat(anualidadAnticipada.getTxtPeriodos().getText()), 6, 1))));
                            }

                        }
                    }
                    case 1 -> {
                        switch (anualidadAnticipada.getCmbPeriodos().getSelectedIndex()) {
                            case 0 -> {
                                anualidadAnticipada.getFmdtResultado().setText(String.valueOf(format.format(Anualidades.anticipadaValorPresenteTasaPeriodica(
                                        Float.parseFloat(anualidadAnticipada.getTxtTasa().getText()), Float.parseFloat(anualidadAnticipada.getTxtValor().getText()), Float.parseFloat(anualidadAnticipada.getTxtPeriodos().getText()), 4, 6))));
                            }
                            case 1 -> {
                                anualidadAnticipada.getFmdtResultado().setText(String.valueOf(format.format(Anualidades.anticipadaValorPresenteTasaPeriodica(
                                        Float.parseFloat(anualidadAnticipada.getTxtTasa().getText()), Float.parseFloat(anualidadAnticipada.getTxtValor().getText()), Float.parseFloat(anualidadAnticipada.getTxtPeriodos().getText()), 4, 4))));
                            }
                            case 2 -> {
                                anualidadAnticipada.getFmdtResultado().setText(String.valueOf(format.format(Anualidades.anticipadaValorPresenteTasaPeriodica(
                                        Float.parseFloat(anualidadAnticipada.getTxtTasa().getText()), Float.parseFloat(anualidadAnticipada.getTxtValor().getText()), Float.parseFloat(anualidadAnticipada.getTxtPeriodos().getText()), 4, 3))));
                            }
                            case 3 -> {
                                anualidadAnticipada.getFmdtResultado().setText(String.valueOf(format.format(Anualidades.anticipadaValorPresenteTasaPeriodica(
                                        Float.parseFloat(anualidadAnticipada.getTxtTasa().getText()), Float.parseFloat(anualidadAnticipada.getTxtValor().getText()), Float.parseFloat(anualidadAnticipada.getTxtPeriodos().getText()), 4, 2))));
                            }
                            case 4 -> {
                                anualidadAnticipada.getFmdtResultado().setText(String.valueOf(format.format(Anualidades.anticipadaValorPresenteTasaPeriodica(
                                        Float.parseFloat(anualidadAnticipada.getTxtTasa().getText()), Float.parseFloat(anualidadAnticipada.getTxtValor().getText()), Float.parseFloat(anualidadAnticipada.getTxtPeriodos().getText()), 4, 12))));
                            }
                            case 5 -> {
                                anualidadAnticipada.getFmdtResultado().setText(String.valueOf(format.format(Anualidades.anticipadaValorPresenteTasaPeriodica(
                                        Float.parseFloat(anualidadAnticipada.getTxtTasa().getText()), Float.parseFloat(anualidadAnticipada.getTxtValor().getText()), Float.parseFloat(anualidadAnticipada.getTxtPeriodos().getText()), 4, 1))));
                            }
                        }
                    }
                    case 2 -> {
                        switch (anualidadAnticipada.getCmbPeriodos().getSelectedIndex()) {
                            case 0 -> {
                                anualidadAnticipada.getFmdtResultado().setText(String.valueOf(format.format(Anualidades.anticipadaValorPresenteTasaPeriodica(
                                        Float.parseFloat(anualidadAnticipada.getTxtTasa().getText()), Float.parseFloat(anualidadAnticipada.getTxtValor().getText()), Float.parseFloat(anualidadAnticipada.getTxtPeriodos().getText()), 3, 6))));
                            }
                            case 1 -> {
                                anualidadAnticipada.getFmdtResultado().setText(String.valueOf(format.format(Anualidades.anticipadaValorPresenteTasaPeriodica(
                                        Float.parseFloat(anualidadAnticipada.getTxtTasa().getText()), Float.parseFloat(anualidadAnticipada.getTxtValor().getText()), Float.parseFloat(anualidadAnticipada.getTxtPeriodos().getText()), 3, 4))));
                            }
                            case 2 -> {
                                anualidadAnticipada.getFmdtResultado().setText(String.valueOf(format.format(Anualidades.anticipadaValorPresenteTasaPeriodica(
                                        Float.parseFloat(anualidadAnticipada.getTxtTasa().getText()), Float.parseFloat(anualidadAnticipada.getTxtValor().getText()), Float.parseFloat(anualidadAnticipada.getTxtPeriodos().getText()), 3, 3))));
                            }
                            case 3 -> {
                                anualidadAnticipada.getFmdtResultado().setText(String.valueOf(format.format(Anualidades.anticipadaValorPresenteTasaPeriodica(
                                        Float.parseFloat(anualidadAnticipada.getTxtTasa().getText()), Float.parseFloat(anualidadAnticipada.getTxtValor().getText()), Float.parseFloat(anualidadAnticipada.getTxtPeriodos().getText()), 3, 2))));
                            }
                            case 4 -> {
                                anualidadAnticipada.getFmdtResultado().setText(String.valueOf(format.format(Anualidades.anticipadaValorPresenteTasaPeriodica(
                                        Float.parseFloat(anualidadAnticipada.getTxtTasa().getText()), Float.parseFloat(anualidadAnticipada.getTxtValor().getText()), Float.parseFloat(anualidadAnticipada.getTxtPeriodos().getText()), 3, 12))));
                            }
                            case 5 -> {
                                anualidadAnticipada.getFmdtResultado().setText(String.valueOf(format.format(Anualidades.anticipadaValorPresenteTasaPeriodica(
                                        Float.parseFloat(anualidadAnticipada.getTxtTasa().getText()), Float.parseFloat(anualidadAnticipada.getTxtValor().getText()), Float.parseFloat(anualidadAnticipada.getTxtPeriodos().getText()), 3, 1))));
                            }
                        }
                    }
                    case 3 -> {
                        switch (anualidadAnticipada.getCmbPeriodos().getSelectedIndex()) {
                            case 0 -> {
                                anualidadAnticipada.getFmdtResultado().setText(String.valueOf(format.format(Anualidades.anticipadaValorPresenteTasaPeriodica(
                                        Float.parseFloat(anualidadAnticipada.getTxtTasa().getText()), Float.parseFloat(anualidadAnticipada.getTxtValor().getText()), Float.parseFloat(anualidadAnticipada.getTxtPeriodos().getText()), 2, 6))));
                            }
                            case 1 -> {
                                anualidadAnticipada.getFmdtResultado().setText(String.valueOf(format.format(Anualidades.anticipadaValorPresenteTasaPeriodica(
                                        Float.parseFloat(anualidadAnticipada.getTxtTasa().getText()), Float.parseFloat(anualidadAnticipada.getTxtValor().getText()), Float.parseFloat(anualidadAnticipada.getTxtPeriodos().getText()), 2, 4))));
                            }
                            case 2 -> {
                                anualidadAnticipada.getFmdtResultado().setText(String.valueOf(format.format(Anualidades.anticipadaValorPresenteTasaPeriodica(
                                        Float.parseFloat(anualidadAnticipada.getTxtTasa().getText()), Float.parseFloat(anualidadAnticipada.getTxtValor().getText()), Float.parseFloat(anualidadAnticipada.getTxtPeriodos().getText()), 2, 3))));
                            }
                            case 3 -> {
                                anualidadAnticipada.getFmdtResultado().setText(String.valueOf(format.format(Anualidades.anticipadaValorPresenteTasaPeriodica(
                                        Float.parseFloat(anualidadAnticipada.getTxtTasa().getText()), Float.parseFloat(anualidadAnticipada.getTxtValor().getText()), Float.parseFloat(anualidadAnticipada.getTxtPeriodos().getText()), 2, 2))));
                            }
                            case 4 -> {
                                anualidadAnticipada.getFmdtResultado().setText(String.valueOf(format.format(Anualidades.anticipadaValorPresenteTasaPeriodica(
                                        Float.parseFloat(anualidadAnticipada.getTxtTasa().getText()), Float.parseFloat(anualidadAnticipada.getTxtValor().getText()), Float.parseFloat(anualidadAnticipada.getTxtPeriodos().getText()), 2, 12))));
                            }
                            case 5 -> {
                                anualidadAnticipada.getFmdtResultado().setText(String.valueOf(format.format(Anualidades.anticipadaValorPresenteTasaPeriodica(
                                        Float.parseFloat(anualidadAnticipada.getTxtTasa().getText()), Float.parseFloat(anualidadAnticipada.getTxtValor().getText()), Float.parseFloat(anualidadAnticipada.getTxtPeriodos().getText()), 2, 1))));
                            }
                        }
                    }
                    case 4 -> {

                        switch (anualidadAnticipada.getCmbPeriodos().getSelectedIndex()) {
                            case 0 -> {
                                anualidadAnticipada.getFmdtResultado().setText(String.valueOf(format.format(Anualidades.anticipadaValorPresenteTasaPeriodica(
                                        Float.parseFloat(anualidadAnticipada.getTxtTasa().getText()), Float.parseFloat(anualidadAnticipada.getTxtValor().getText()), Float.parseFloat(anualidadAnticipada.getTxtPeriodos().getText()), 12, 6))));
                            }
                            case 1 -> {
                                anualidadAnticipada.getFmdtResultado().setText(String.valueOf(format.format(Anualidades.anticipadaValorPresenteTasaPeriodica(
                                        Float.parseFloat(anualidadAnticipada.getTxtTasa().getText()), Float.parseFloat(anualidadAnticipada.getTxtValor().getText()), Float.parseFloat(anualidadAnticipada.getTxtPeriodos().getText()), 12, 4))));
                            }
                            case 2 -> {
                                anualidadAnticipada.getFmdtResultado().setText(String.valueOf(format.format(Anualidades.anticipadaValorPresenteTasaPeriodica(
                                        Float.parseFloat(anualidadAnticipada.getTxtTasa().getText()), Float.parseFloat(anualidadAnticipada.getTxtValor().getText()), Float.parseFloat(anualidadAnticipada.getTxtPeriodos().getText()), 12, 3))));
                            }
                            case 3 -> {
                                anualidadAnticipada.getFmdtResultado().setText(String.valueOf(format.format(Anualidades.anticipadaValorPresenteTasaPeriodica(
                                        Float.parseFloat(anualidadAnticipada.getTxtTasa().getText()), Float.parseFloat(anualidadAnticipada.getTxtValor().getText()), Float.parseFloat(anualidadAnticipada.getTxtPeriodos().getText()), 12, 2))));
                            }
                            case 4 -> {
                                anualidadAnticipada.getFmdtResultado().setText(String.valueOf(format.format(Anualidades.anticipadaValorPresenteTasaPeriodica(
                                        Float.parseFloat(anualidadAnticipada.getTxtTasa().getText()), Float.parseFloat(anualidadAnticipada.getTxtValor().getText()), Float.parseFloat(anualidadAnticipada.getTxtPeriodos().getText()), 12, 12))));
                            }
                            case 5 -> {
                                anualidadAnticipada.getFmdtResultado().setText(String.valueOf(format.format(Anualidades.anticipadaValorPresenteTasaPeriodica(
                                        Float.parseFloat(anualidadAnticipada.getTxtTasa().getText()), Float.parseFloat(anualidadAnticipada.getTxtValor().getText()), Float.parseFloat(anualidadAnticipada.getTxtPeriodos().getText()), 12, 1))));
                            }
                        }
                    }
                }
            }
        }
    }
}
