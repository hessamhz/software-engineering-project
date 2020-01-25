## <p dir='rtl' align='right'>طراحی پایگاه داده</p>
<p dir='rtl' align='right'>جداول مورد نیاز در طراحی این پروژه به شرح زیر میباشند:</p>

## <p dir='rtl' align='right'>_User</p>
<p dir='rtl' align='right'>در این جدول اطلاعات هر شخص بدون در نظر گرفتن نقش در پایگاه داده ذخیره میشود.</p>
<p dir='rtl' align='right'>ID [int] : شماره شناسایی هر شخص</p>
<p dir='rtl' align='right'>first_name [varchar(30)]: نام </p>
<p dir='rtl' align='right'>last_name [varchar(30)] : نام خانوادگی</p>
<p dir='rtl' align='right'>username [varchar(30)]: شناسه کاربری </p>
<p dir='rtl' align='right'>password [varchar(10)] : رمز عبور </p>
<p dir='rtl' align='right'>user_type [varchar(3)]: نقش کاربر که یکی از مقادیر tr,te یا sup میباشد </p>

## <p dir='rtl' align='right'>Supporter</p>
<p dir='rtl' align='right'>در این جدول اطلاعات Supporter نگه داری میشود. در اصل این نقش ارتباط یک به یک با User دارد و اطلاعات مشخص Supporter در این جدول نگه داری میشوند..</p>
<p dir='rtl' align='right'>ID [int] : کلید خارجی به جدول User</p>
<p dir='rtl' align='right'>personel number [int]: شماره پرسنلی </p>
<p dir='rtl' align='right'>rating [int] : امتیازی که به این Supporter از 1 تا 5 داده شده است.</p>


## <p dir='rtl' align='right'>Tasker</p>
<p dir='rtl' align='right'>اطلاعات Tasker در این جدول نگه داری میشوند. همانند Supporter این جدول هم ارتباط یک به یک با جدول User دارد.</p>
<p dir='rtl' align='right'>tasker_num [int] : شماره هر Tasker</p>
<p dir='rtl' align='right'>ID [int] : کلید خارجی به جدول User</p>
<p dir='rtl' align='right'>balance [float]: مجموع درامدهای Tasker </p>
<p dir='rtl' align='right'>rating [int] : امتیازی که به این Tasker از 1 تا 5 داده شده است.</p>


## <p dir='rtl' align='right'>Taskee</p>
<p dir='rtl' align='right'>اطلاعات Taskee با ارتباط یک به یک با جدول User در این جدول ذخیره میشود.</p>
<p dir='rtl' align='right'>taskee_num [int] : شماره هر Taskee</p>
<p dir='rtl' align='right'>ID [int] : کلید خارجی به جدول User</p>
<p dir='rtl' align='right'>balance [float]: مجموع پرداختی های Taskee </p>
<p dir='rtl' align='right'>rating [int] : امتیازی که به این Taskee از 1 تا 5 داده شده است.</p>



## <p dir='rtl' align='right'>Catagory</p>
<p dir='rtl' align='right'>در این جدول تمامی دسته بندی های کار های موجود و توضیحی از این دسته نگه داری میشود. کارهای هر دسته در جدول Task مشخص خواهند شد.</p>
<p dir='rtl' align='right'>ID [int] : شماره هر دسته</p>
<p dir='rtl' align='right'>name [varchar(30)]: نام دسته </p>
<p dir='rtl' align='right'>description [nvarchar(50)] : توضیح دسته</p>


## <p dir='rtl' align='right'>Task</p>
<p dir='rtl' align='right'>تمامی Task هایی که در سیستم موجود هستند یا از ظرف Taskee درخواست میشوند، در این جدول نگه داری خواهند شد. دسته ی هر کار با داشتن کلید خارجی به جدول Catagory مشخص میشود.</p>
<p dir='rtl' align='right'>ID [int] : شماره هر کار</p>
<p dir='rtl' align='right'>start_time [time(0)]: زمان شروع کار </p>
<p dir='rtl' align='right'>finish_time [time(0)]: زمان پایان کار </p>
<p dir='rtl' align='right'> cost [float] : هزینه تعریف شده برای کار</p>
<p dir='rtl' align='right'> description [nvarchar(50)] : توضیحات کار</p>
<p dir='rtl' align='right'> location [nvarchar(50)] : آدرس محل کار</p>
<p dir='rtl' align='right'> catagory [int] : دسته مربوطه</p>
<p dir='rtl' align='right'> final_offer [float] : هزینه توافقی</p>
<p dir='rtl' align='right'> is_started [int] : در صورت شروع شدن Task یک میشود</p>
<p dir='rtl' align='right'> is_stalled [int] : زمانی که برای task به supporter تیکت زده میشود، این مقدار یک میشود.</p>
<p dir='rtl' align='right'> is_finished [int] : در صورت تمام شدن Task یک میشود</p>
<p dir='rtl' align='right'> is_extended [int] : در صورتی که Taskee زمان کار را تغییر دهد، این مقدار یک میشود.</p>
<p dir='rtl' align='right'> is_cancelled [int] : در صورتی که از طرف هر یک از طرفین Task لغو شود، یک میشود</p>


## <p dir='rtl' align='right'>Offer</p>
<p dir='rtl' align='right'>تمامی Task هایی که در سیستم موجود هستند یا از ظرف Taskee درخواست میشوند، در این جدول نگه داری خواهند شد. دسته ی هر کار با داشتن کلید خارجی به جدول Catagory مشخص میشود.</p>
<p dir='rtl' align='right'>ID [int] : شماره هر offer</p>
<p dir='rtl' align='right'>date [datetime]: زمان ثبت شدن offer </p>
<p dir='rtl' align='right'>fee [float]:  هزینه ی مشخص شده در offer</p>
<p dir='rtl' align='right'> description [nvarchar(50)] : توضیحات </p>
<p dir='rtl' align='right'> Task [int] : کاری که روی آن offer قرار گرفته است</p>
<p dir='rtl' align='right'> Tasker [int] : شماره Tasker مربوطه</p>
<p dir='rtl' align='right'> is_rejected [int] : در صورتی که Taskee پیشنهاد Tasker را نپذیرد، این مقدار یک میشود.</p>
<p dir='rtl' align='right'> is_counted [int] : در صورتی که طرفین در حال مذاکره بر روی قیمت باشند این مقدار یک میشود</p>
<p dir='rtl' align='right'> is_pending [int] : در صورتی که Offer منتظر تایید از طرف مقابل باشد این مقدار یک میشود.</p>
<p dir='rtl' align='right'> is_cancelled [int] : در صورتی که offer لغو شود این مقدار یک میشود. </p>

## <p dir='rtl' align='right'>Counter_Offer</p>
<p dir='rtl' align='right'>ممکن است که Tasker و Taskee با قیمت پیشنهاد شده موافق نباشند در این صورت شروع به مذاکره بر روی هزینه نهایی Task میکنند. این مذاکرات در این جدول ثبت میشود.</p>
<p dir='rtl' align='right'>ID [int] : شماره هر رکورد</p>
<p dir='rtl' align='right'>date [datetime]: زمان ثبت شدن پیشنهاد </p>
<p dir='rtl' align='right'>offer [int]: شماره offer مربوطه</p>
<p dir='rtl' align='right'>description [nvarchar(50)] : توضیحات</p>
<p dir='rtl' align='right'>fee [float]:  هزینه ی پیشنهادی</p>

## <p dir='rtl' align='right'>Call</p>
<p dir='rtl' align='right'> تماس هایی که با Supporter براقرار میشود در این جدول ذخیره میشوند.</p>
<p dir='rtl' align='right'>ID [int] : شماره هر رکورد</p>
<p dir='rtl' align='right'>supporter [int]: شماره supporter پاسخ دهنده </p>
<p dir='rtl' align='right'>date [datetime]: تاریخ و زمان برقراری تماس</p>

## <p dir='rtl' align='right'>Ticket</p>
<p dir='rtl' align='right'> اگر Tasker یا Taskee سوال یا مشکلی داشتند، با درخوایت تیکت در این بخش سوال خود را مطرح میکنند و Supporter باید به این مشکل رسیدگی کند.</p>
<p dir='rtl' align='right'>ID [int] : شماره هر تیکت</p>
<p dir='rtl' align='right'>date [datetime]: تاریخ و زمان ثبت تیکت</p>
<p dir='rtl' align='right'>supporter [int]: شماره supporter پاسخ دهنده </p>
<p dir='rtl' align='right'>ticketer [int]: کاربری که تیکت زده است. ticketer با استفاده از جدول User مشخص میشود.</p>
<p dir='rtl' align='right'>issue [nvarchar(100)]: مسئله یمطرح شده </p>
<p dir='rtl' align='right'>is_answered [int]: در صورتی که مسئله پاسخ دهی شده و برطرف شود این فیلد یک میشود.</p>
