package cn.ktv.ktvphone.scanner.view;

import java.util.ArrayList;
import java.util.Collection;
import java.util.List;

import android.content.Context;
import android.content.res.Resources;
import android.graphics.Bitmap;
import android.graphics.BitmapFactory;
import android.graphics.Canvas;
import android.graphics.Color;
import android.graphics.Paint;
import android.graphics.Rect;
import android.graphics.drawable.BitmapDrawable;
import android.util.AttributeSet;
import android.view.View;
import cn.ktv.ktvphone.R;
import cn.ktv.ktvphone.scanner.camera.CameraManager;

import com.google.zxing.ResultPoint;

public final class ViewfinderView extends View {

	private static final long ANIMATION_DELAY = 10L;
	private static final int OPAQUE = 0xFF;

	private int CORNER_PADDING;

	private static int MIDDLE_LINE_WIDTH;

	private static int MIDDLE_LINE_PADDING;

	private static final int SPEEN_DISTANCE = 10;

	private Paint paint;

	private int slideTop;

	private int slideBottom;

	private static final int MAX_RESULT_POINTS = 20;

	private Bitmap resultBitmap;

	private final int maskColor;
	private final int resultColor;

	private final int resultPointColor;
	private List<ResultPoint> possibleResultPoints;

	private List<ResultPoint> lastPossibleResultPoints;

	boolean isFirst = true;

	private CameraManager cameraManager;

	public ViewfinderView(Context context, AttributeSet attrs) {
		super(context, attrs);

		CORNER_PADDING = dip2px(context, 0.0F);
		MIDDLE_LINE_PADDING = dip2px(context, 20.0F);
		MIDDLE_LINE_WIDTH = dip2px(context, 3.0F);

		paint = new Paint(Paint.ANTI_ALIAS_FLAG);

		Resources resources = getResources();
		maskColor = resources.getColor(R.color.viewfinder_mask);
		resultColor = resources.getColor(R.color.result_view);

		resultPointColor = resources.getColor(R.color.possible_result_points);
		possibleResultPoints = new ArrayList<ResultPoint>(5);
		lastPossibleResultPoints = null;

	}

	public void setCameraManager(CameraManager cameraManager) {
		this.cameraManager = cameraManager;
	}

	@Override
	public void onDraw(Canvas canvas) {
		if (cameraManager == null) {
			return;
		}
		Rect frame = cameraManager.getFramingRect();
		if (frame == null) {
			return;
		}

		drawCover(canvas, frame);

		if (resultBitmap != null) {
			paint.setAlpha(0xA0);
			canvas.drawBitmap(resultBitmap, null, frame, paint);
		}
		else {

			drawRectEdges(canvas, frame);

			drawScanningLine(canvas, frame);

			List<ResultPoint> currentPossible = possibleResultPoints;
			Collection<ResultPoint> currentLast = lastPossibleResultPoints;
			if (currentPossible.isEmpty()) {
				lastPossibleResultPoints = null;
			}
			else {
				possibleResultPoints = new ArrayList<ResultPoint>(5);
				lastPossibleResultPoints = currentPossible;
				paint.setAlpha(OPAQUE);
				paint.setColor(resultPointColor);
				for (ResultPoint point : currentPossible) {
					canvas.drawCircle(frame.left + point.getX(), frame.top
							+ point.getY(), 6.0f, paint);
				}
			}
			if (currentLast != null) {
				paint.setAlpha(OPAQUE / 2);
				paint.setColor(resultPointColor);
				for (ResultPoint point : currentLast) {
					canvas.drawCircle(frame.left + point.getX(), frame.top
							+ point.getY(), 3.0f, paint);
				}
			}

			postInvalidateDelayed(ANIMATION_DELAY, frame.left, frame.top,
					frame.right, frame.bottom);

		}
	}

	private void drawScanningLine(Canvas canvas, Rect frame) {

		if (isFirst) {
			isFirst = false;
			slideTop = frame.top;
			slideBottom = frame.bottom;
		}

		slideTop += SPEEN_DISTANCE;
		if (slideTop >= slideBottom) {
			slideTop = frame.top;
		}

		Rect lineRect = new Rect();
		lineRect.left = frame.left + MIDDLE_LINE_PADDING;
		lineRect.right = frame.right - MIDDLE_LINE_PADDING;
		lineRect.top = slideTop;
		lineRect.bottom = (slideTop + MIDDLE_LINE_WIDTH);
		canvas.drawBitmap(((BitmapDrawable) getResources()
				.getDrawable(R.drawable.ic_scan_laser)).getBitmap(), null,
				lineRect, paint);

	}

	private void drawCover(Canvas canvas, Rect frame) {

		int width = canvas.getWidth();
		int height = canvas.getHeight();

		paint.setColor(resultBitmap != null ? resultColor : maskColor);

		canvas.drawRect(0, 0, width, frame.top, paint);
		canvas.drawRect(0, frame.top, frame.left, frame.bottom + 1, paint);
		canvas.drawRect(frame.right + 1, frame.top, width, frame.bottom + 1,
				paint);
		canvas.drawRect(0, frame.bottom + 1, width, height, paint);
	}

	private void drawRectEdges(Canvas canvas, Rect frame) {

		paint.setColor(Color.WHITE);
		paint.setAlpha(OPAQUE);

		Resources resources = getResources();

		Bitmap bitmapCornerTopleft = BitmapFactory.decodeResource(resources,
				R.drawable.ic_scan_corner_top_left);
		Bitmap bitmapCornerTopright = BitmapFactory.decodeResource(resources,
				R.drawable.ic_scan_corner_top_right);
		Bitmap bitmapCornerBottomLeft = BitmapFactory.decodeResource(resources,
				R.drawable.ic_scan_corner_bottom_left);
		Bitmap bitmapCornerBottomRight = BitmapFactory.decodeResource(resources, 
				R.drawable.ic_scan_corner_bottom_right);

		canvas.drawBitmap(bitmapCornerTopleft, frame.left + CORNER_PADDING,
				frame.top + CORNER_PADDING, paint);
		canvas.drawBitmap(bitmapCornerTopright, frame.right - CORNER_PADDING
				- bitmapCornerTopright.getWidth(), frame.top + CORNER_PADDING,
				paint);
		canvas.drawBitmap(bitmapCornerBottomLeft, frame.left + CORNER_PADDING,
				2 + (frame.bottom - CORNER_PADDING - bitmapCornerBottomLeft
						.getHeight()), paint);
		canvas.drawBitmap(bitmapCornerBottomRight, frame.right - CORNER_PADDING
				- bitmapCornerBottomRight.getWidth(), 2 + (frame.bottom
				- CORNER_PADDING - bitmapCornerBottomRight.getHeight()), paint);

		bitmapCornerTopleft.recycle();
		bitmapCornerTopleft = null;
		bitmapCornerTopright.recycle();
		bitmapCornerTopright = null;
		bitmapCornerBottomLeft.recycle();
		bitmapCornerBottomLeft = null;
		bitmapCornerBottomRight.recycle();
		bitmapCornerBottomRight = null;

	}

	public void drawViewfinder() {
		Bitmap resultBitmap = this.resultBitmap;
		this.resultBitmap = null;
		if (resultBitmap != null) {
			resultBitmap.recycle();
		}
		invalidate();
	}

	public void drawResultBitmap(Bitmap barcode) {
		resultBitmap = barcode;
		invalidate();
	}

	public void addPossibleResultPoint(ResultPoint point) {
		List<ResultPoint> points = possibleResultPoints;
		synchronized (points) {
			points.add(point);
			int size = points.size();
			if (size > MAX_RESULT_POINTS) {
				points.subList(0, size - MAX_RESULT_POINTS / 2).clear();
			}
		}
	}

	public int dip2px(Context context, float dipValue) {
		final float scale = context.getResources().getDisplayMetrics().density;
		return (int) (dipValue * scale + 0.5f);
	}

}
