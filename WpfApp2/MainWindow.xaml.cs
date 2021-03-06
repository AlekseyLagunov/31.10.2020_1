﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp2
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            txtBl.Text= "Сегодня Рыбы будут настроены третировать своих близких, заставляя их заниматься благоустройством личного пространства: кухни, дачи, рабочего кабинета…" +
                            " Ничего не поделаешь – им в голову придет масса блестящих идей на этот счет, которые потребуют своего воплощения. Что касается мелких проектов," +
                            " вроде генеральной уборки или покупок предметов быта, то это еще не беда. Главное, чтобы Рыбы на скорую руку не затеяли крупную перестановку мебели или даже ремонт!";
        }

        private void CheckBox_Checked_1(object sender, RoutedEventArgs e)
        {
            txtBl.Text = "Сегодня если Водолей захочет произвести впечатление на окружающих, его главным козырем должен стать интеллект." +
                            " Неважно, о каком собеседнике идет речь, – о начальнике, любимом человеке, случайном попутчике или лучшем друге: сегодня в любых кругах будут востребованы темы," +
                            " далекие от светской болтовни. Политика, экономика, философия, математика – любые науки, которые помогут Водолею блеснуть умом," +
                            " ему рекомендуется срочно освежить в памяти, вспомнив школьные годы.";
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            txtBl.Text = "Сегодня звезды гороскопа советуют Козерогу внимательно слушать, что происходит вокруг: окружающие будут говорить важные вещи." +
                            " День предоставляет Козерогу шанс собрать информацию по какому-то вопросу, услышать ценный совет или отличную идею. В дальнейшем все это может ему пригодиться," +
                            " поэтому сегодня Козерогу не стоит отвлекать внимание окружающих на себя. Наоборот, будьте внимательны сами: учитесь, слушайте, запоминайте.";
        }

        private void RadioButton_Checked_1(object sender, RoutedEventArgs e)
        {
            txtBl.Text = "Сегодня Стрелец, решая любой вопрос, будет похож на сороконожку, которую спросили, с какой ноги она начинает идти!" +
                            " Так же как сороконожка, задумавшись, запуталась в конечностях, так и Стрелец рискует заблудиться в лабиринте собственных мыслей." +
                            " Что ж, понятия «думать» и «усложнять» находятся на разных полюсах. Первое всегда полезно, а вот второе Стрелец готов продемонстрировать сегодня во всей красе," +
                            " вызывая недовольство окружающих.";
        }

        private void RadioButton_Checked_2(object sender, RoutedEventArgs e)
        {
            txtBl.Text = "Даже если Скорпион не слишком любит интеллектуальные дискуссии, сегодня он может сделать исключение из правил. " +
                            "Причем, чем горячее спор получится, тем лучше! В идеале Скорпион хотел бы встретиться с противником, с которым его точки зрения полностью противоположны," +
                            " ну а если нет – он готов спровоцировать собеседника на спор. Цель этого проста: Скорпион сегодня настолько уверен в своем интеллектуальном превосходстве," +
                            " что не прочь продемонстрировать его всем вокруг.";
        }

        private void RadioButton_Checked_3(object sender, RoutedEventArgs e)
        {
            txtBl.Text = "Сегодня в разговорах Весы то и дело могут проявлять рассеянность или терять нить беседы, и все из-за того," +
                            " что собеседники будут заставлять их скучать! Обычные бытовые темы или светские сплетни набили оскомину, а по-настоящему умного собеседника надо найти." +
                            " Звезды гороскопа советуют Весам выбраться сегодня куда-нибудь, где у них есть шанс встретиться и поговорить с интересными, знающими людьми." +
                            " Такая беседа необходима Весам, как глоток свежего воздуха!";
        }

        private void RadioButton_Checked_4(object sender, RoutedEventArgs e)
        {
            txtBl.Text = "Сегодня Дева способна все в своей жизни аккуратно разложить по полочкам! Спонтанность хороша не всегда," +
                            " чаще всего залог успешного дела – это план, учитывающий мельчайшие детали. Именно к построению таких планов звезды гороскопа склоняют Деву," +
                            " согласно поговорке «Семь раз отмерь». Не важно, о чем идет речь, – о крупном событии в ее жизни, диете, отпуске или вечеринке." +
                            " Спланировав сегодня любое действие заранее, Дева обречет его на успех!";
        }

        private void RadioButton_Checked_5(object sender, RoutedEventArgs e)
        {
            txtBl.Text = "Сегодня звезды гороскопа советуют Льву сосредоточиться на создании интеллектуальных связей с людьми." +
                            " Вначале любое общение строится по принципу симпатии-антипатии, однако для более глубоких отношений одних лишь симпатий мало," +
                            " необходимо найти общие темы и интересы. Именно к такому «продвинутому» общению в сфере логики, а не чувств," +
                            " день и склоняет сегодня Льва, призывая его вывести свои отношения с кем-то на качественно новый уровень.";
        }

        private void RadioButton_Checked_6(object sender, RoutedEventArgs e)
        {
            txtBl.Text = "Сегодня Рак с удовольствием почувствует себя винтиком в чужом механизме – если только этот механизм хорошо отлажен и не скрипит." +
                            " Он будет способен отлично работать в команде или под чьим-то началом, главное, чтобы Рак четко знал, что он делает и для чего." +
                            " Только поняв до конца логику процесса и свою в нем роль, Рак будет готов осуществлять то, что задумано другими." +
                            " Ну, а если окружающие не сочтут нужным посвящать Рака во все детали, им же хуже – придется все делать самим.";
        }

        private void RadioButton_Checked_7(object sender, RoutedEventArgs e)
        {
            txtBl.Text = "Сегодня Близнецы во всех сферах жизни, в том числе и в общении, будут опираться на логику, а не на чувства." +
                            " Вместо того, чтобы гадать, что творится в душах людей, они захотят узнать это точно с помощью разговоров или даже вопросов в лоб." +
                            " Впрочем, и сами Близнецы не будут таить от окружающих свои мысли и намерения, подробно объясняя, чего они хотят." +
                            " Сегодня такая практика окажется эффективной: Близнецам будет сопутствовать успех.";
        }

        private void RadioButton_Checked_8(object sender, RoutedEventArgs e)
        {
            txtBl.Text = "Сегодня в Тельце проснется финансист! Его мозг будет работать четко, жонглируя цифрами и фактами." +
                            " Если Телец посвятит этот день мыслям о том, как улучшить материальное положение, он произведет на свет отличный план," +
                            " который поможет ему неплохо заработать. Впрочем, не менее эффективными окажутся проекты того," +
                            " как Тельцу создать вокруг себя атмосферу комфорта. Планирование отпуска, ремонта, любых крупных покупок сегодня поможет Тельцу не прогадать.";
        }

        private void RadioButton_Checked_9(object sender, RoutedEventArgs e)
        {
            txtBl.Text = "Сегодня вся энергия Овна рискует уйти в разговоры, открывающие перед ним тайны Вселенной." +
                            " День склоняет его к интеллектуальным беседам на самые серьезные и отвлеченные темы, вроде человеческой психики," +
                            " духовного развития, секретов мироздания, происхождения снежного человека… Возможно, Овен встретит сегодня людей," +
                            " с которыми сможет на эти темы всласть поговорить. Главное, витая в облаках, не потерять почву под ногами.";
        }
    }
}
