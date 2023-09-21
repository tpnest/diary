import '/npm/swiper/7.4.1/swiper-bundle.min.js';
export function initSwiper(dotNetCallbackRef, callbackMethod, dom, selector, index) {
    if (dom == null) {
        return;
    }

    dom.Swiper = new Swiper(selector, {
        observer: true,
        observeParents: true,
        observeSlideChildren: true,
        //autoHeight: true,//�Զ��߶�
        simulateTouch: false,//��ֹ���ģ��
        initialSlide: index,//�趨��ʼ��ʱslide������
        resistanceRatio: 0.7,
        on: {
            slideChangeTransitionStart: function () {
                dotNetCallbackRef.invokeMethodAsync(callbackMethod, this.activeIndex);
            },
        }
    });
}

export function slideTo(dom, value) {
    dom.Swiper.slideTo(value);
}
