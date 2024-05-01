# ClientServiceForEureka

## steeltoeoss/eureka-server چیست؟

steeltoeoss/eureka-server یک پیاده‌سازی منبع باز از Netflix Eureka Server است که برای کشف خدمات در معماری‌های میکروسرویس استفاده می‌شود.  این سرور به عنوان یک رجیستری مرکزی برای خدمات میکروسرویس عمل می‌کند و به کلاینت‌ها اجازه می‌دهد تا مکان نمونه‌های خدمات در حال اجرا را پیدا کنند.

### مزایای استفاده از steeltoeoss/eureka-server:

* کشف خدمات:  Eureka Server به کلاینت‌ها اجازه می‌دهد تا به طور خودکار مکان نمونه‌های خدمات در حال اجرا را پیدا کنند.
* بارگذاری متعادل:  Eureka Server می‌تواند برای توزیع ترافیک بین چندین نمونه از یک سرویس استفاده شود.
* مقاومت در برابر خطا:  Eureka Server می‌تواند از دست رفتن نمونه‌های خدمات را تشخیص دهد و به طور خودکار کلاینت‌ها را به نمونه‌های جدید هدایت کند.
* مشاهده:  Eureka Server یک رابط کاربری برای مشاهده وضعیت خدمات ثبت شده ارائه می‌دهد.

### نحوه نصب steeltoeoss/eureka-server روی Docker:

1. Docker را روی سیستم خود نصب کنید.
2. دستور زیر را برای کشش تصویر steeltoeoss/eureka-server اجرا کنید:

docker pull steeltoeoss/eureka-server

3. دستور زیر را برای اجرای یک نمونه از Eureka Server اجرا کنید:

docker run -d -p 8761:8761 steeltoeoss/eureka-server

این دستور یک نمونه از Eureka Server را در پورت 8761 اجرا می‌کند. می‌توانید با استفاده از مرورگر وب خود به رابط کاربری Eureka Server در http://localhost:8761 دسترسی پیدا کنید.

### نحوه ذخیره steeltoeoss/eureka-server روی سیستم:

می‌توانید تصویر steeltoeoss/eureka-server را با استفاده از دستور docker save ذخیره کنید. به عنوان مثال، دستور زیر تصویر را در یک فایل با نام eureka-server.tar ذخیره می‌کند:

docker save steeltoeoss/eureka-server > eureka-server.tar

سپس می‌توانید تصویر را با استفاده از دستور docker load بازیابی کنید. به عنوان مثال، دستور زیر تصویر را از فایل eureka-server.tar بارگیری می‌کند:

docker load < eureka-server.tar

### نحوه اجرای steeltoeoss/eureka-server از سیستم:

می‌توانید با استفاده از دستور docker run Eureka Server را از سیستم خود اجرا کنید. به عنوان مثال، دستور زیر یک نمونه از Eureka Server را در پورت 8761 اجرا می‌کند:

docker run -d -p 8761:8761 eureka-server

این دستور فرآیندی را در پس‌زمینه اجرا می‌کند که Eureka Server را در پورت 8761 اجرا می‌کند. می‌توانید با استفاده از دستور docker ps لیست فرآیندهای در حال اجرا را مشاهده کنید.

### کارهای steeltoeoss/eureka-server:

* ثبت خدمات:  کلاینت‌ها می‌توانند خدمات خود را در Eureka Server ثبت کنند.
* کشف خدمات:  کلاینت‌ها می‌توانند برای یافتن مکان نمونه‌های خدمات در حال اجرا با Eureka Server پرس و جو کنند.
* بارگذاری متعادل:  Eureka Server می‌تواند برای توزیع ترافیک بین چندین نمونه از یک سرویس استفاده شود.
* مقاومت در برابر خطا:  Eureka Server می‌تواند از دست رفتن نمونه‌های خدمات را تشخیص دهد و به طور خودکار کلاینت‌ها را به نمونه‌های جدید هدایت کند.
* مشاهده:  Eureka Server یک رابط کاربری برای مشاهده وضعیت خدمات ثبت شده ارائه می‌دهد.

نکته:  steeltoeoss/eureka-server برای استفاده در محیط‌های تولیدی در نظر گرفته نشده است. برای استفاده در محیط‌های تولیدی، باید از یک پیاده‌سازی پشتیبانی شده از Netflix Eureka Server مانند Amazon Elastic Container Service (ECS) یا Kubernetes استفاده کنید.
